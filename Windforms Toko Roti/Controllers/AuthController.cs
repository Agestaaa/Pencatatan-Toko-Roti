using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windforms_Toko_Roti.Database;
using Windforms_Toko_Roti.Models;

namespace Windforms_Toko_Roti.Controllers
{
    public class AuthController
    {
        public (bool Sukses, string Pesan, Users Pengguna) ProsesLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return (false, "Username dan password tidak boleh kosong.", null);
            }

            try
            {
                using (var conn = NYAMBUNG.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            u.id_users, u.username, u.password_users, u.is_pimpinan,
                            k.id_karyawan, k.nama_lengkap,
                            d.nama_divisi
                        FROM users u
                        LEFT JOIN karyawan k ON u.id_users = k.id_users
                        LEFT JOIN divisi d ON k.id_divisi = d.id_divisi
                        WHERE u.username = @username AND u.password_users = @password
                        LIMIT 1;";

                    Users akunTerautentikasi = null;

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Trim());
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isPimpinan = Convert.ToBoolean(reader["is_pimpinan"]);
                                int idUsers = Convert.ToInt32(reader["id_users"]);
                                string uname = reader["username"].ToString();
                                string pwd = reader["password_users"].ToString();

                                if (isPimpinan)
                                {
                                    akunTerautentikasi = new AkunOwner
                                    {
                                        IdUsers = idUsers,
                                        Username = uname,
                                        PasswordUsers = pwd,
                                        NamaLengkap = reader["nama_lengkap"] != DBNull.Value
                                            ? reader["nama_lengkap"].ToString()
                                            : "Owner Cloud Bakery"
                                    };
                                }
                                else
                                {
                                    akunTerautentikasi = new AkunKaryawan
                                    {
                                        IdUsers = idUsers,
                                        Username = uname,
                                        PasswordUsers = pwd,
                                        IdKaryawan = reader["id_karyawan"] != DBNull.Value
                                            ? Convert.ToInt32(reader["id_karyawan"])
                                            : 0,
                                        NamaLengkap = reader["nama_lengkap"] != DBNull.Value
                                            ? reader["nama_lengkap"].ToString()
                                            : uname,
                                        NamaDivisi = reader["nama_divisi"] != DBNull.Value
                                            ? reader["nama_divisi"].ToString()
                                            : "Pekerja"
                                    };
                                }
                            }
                        }
                    }

                    if (akunTerautentikasi == null)
                    {
                        return (false, "Username atau password salah.", null);
                    }

                    // Catat kehadiran otomatis untuk pekerja (non-pimpinan)
                    if (!akunTerautentikasi.IsPimpinan)
                    {
                        CatatKehadiranHarian(conn, akunTerautentikasi.IdUsers);
                    }

                    return (true, $"Selamat datang, {akunTerautentikasi.NamaLengkap} ({akunTerautentikasi.NamaDivisi})!", akunTerautentikasi);
                }
            }
            catch (Exception ex)
            {
                return (false, "Terjadi kesalahan koneksi database: " + ex.Message, null);
            }
        }

        private void CatatKehadiranHarian(NpgsqlConnection conn, int idUsers)
        {
            // Cek apakah pekerja sudah tercatat absen hari ini agar tidak duplikat
            string sqlCek = @"
                SELECT COUNT(*) FROM kehadiran 
                WHERE id_users = @id_users AND DATE(tanggal) = CURRENT_DATE;";

            using (var cmdCek = new NpgsqlCommand(sqlCek, conn))
            {
                cmdCek.Parameters.AddWithValue("@id_users", idUsers);
                long sudahAbsen = Convert.ToInt64(cmdCek.ExecuteScalar());

                if (sudahAbsen == 0)
                {
                    string sqlInsert = @"
                        INSERT INTO kehadiran (tanggal, status, id_users)
                        VALUES (CURRENT_TIMESTAMP, 'Hadir', @id_users);";

                    using (var cmdInsert = new NpgsqlCommand(sqlInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@id_users", idUsers);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
