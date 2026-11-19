using Windforms_Toko_Roti.Database;
using Windforms_Toko_Roti.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Windforms_Toko_Roti.Controllers
{
    public class KaryawanController
    {
        // Mengambil daftar divisi untuk isi ComboBox
        public List<Divisi> GetAllDivisi()
        {
            var list = new List<Divisi>();
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id_divisi, nama_divisi FROM divisi ORDER BY id_divisi ASC;";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Divisi
                        {
                            IdDivisi = Convert.ToInt32(reader["id_divisi"]),
                            NamaDivisi = reader["nama_divisi"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        // READ: Mengambil seluruh data pekerja beserta akun login-nya
        public List<Karyawan> GetAllKaryawan()
        {
            var list = new List<Karyawan>();
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT k.id_karyawan, k.nama_lengkap, k.nik, k.alamat, k.email, k.nohp,
                           u.id_users, u.username, u.password_users,
                           d.id_divisi, d.nama_divisi
                    FROM karyawan k
                    INNER JOIN users u ON k.id_users = u.id_users
                    LEFT JOIN divisi d ON k.id_divisi = d.id_divisi
                    WHERE u.is_pimpinan = FALSE
                    ORDER BY k.id_karyawan ASC;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Karyawan
                        {
                            IdKaryawan = Convert.ToInt32(reader["id_karyawan"]),
                            NamaLengkap = reader["nama_lengkap"].ToString(),
                            Nik = reader["nik"].ToString(),
                            Alamat = reader["alamat"].ToString(),
                            Email = reader["email"].ToString(),
                            NoHp = reader["nohp"].ToString(),
                            IdUsers = Convert.ToInt32(reader["id_users"]),
                            Username = reader["username"].ToString(),
                            PasswordUsers = reader["password_users"].ToString(),
                            IdDivisi = reader["id_divisi"] != DBNull.Value ? Convert.ToInt32(reader["id_divisi"]) : 0,
                            NamaDivisi = reader["nama_divisi"] != DBNull.Value ? reader["nama_divisi"].ToString() : "-"
                        });
                    }
                }
            }
            return list;
        }

        // CREATE: Simpan ke tabel users dulu, lalu ambil id_users untuk disimpan ke tabel karyawan
        public void TambahKaryawan(Karyawan data)
        {
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlUser = @"
                            INSERT INTO users (username, password_users, is_pimpinan)
                            VALUES (@username, @password, FALSE)
                            RETURNING id_users;";

                        int idUserBaru;
                        using (var cmdUser = new NpgsqlCommand(sqlUser, conn, trans))
                        {
                            cmdUser.Parameters.AddWithValue("@username", data.Username);
                            cmdUser.Parameters.AddWithValue("@password", data.PasswordUsers);
                            idUserBaru = Convert.ToInt32(cmdUser.ExecuteScalar());
                        }

                        string sqlKaryawan = @"
                            INSERT INTO karyawan (nama_lengkap, nik, alamat, email, nohp, id_divisi, id_users)
                            VALUES (@nama, @nik, @alamat, @email, @nohp, @id_divisi, @id_users);";

                        using (var cmdKaryawan = new NpgsqlCommand(sqlKaryawan, conn, trans))
                        {
                            cmdKaryawan.Parameters.AddWithValue("@nama", data.NamaLengkap);
                            cmdKaryawan.Parameters.AddWithValue("@nik", data.Nik);
                            cmdKaryawan.Parameters.AddWithValue("@alamat", data.Alamat);
                            cmdKaryawan.Parameters.AddWithValue("@email", data.Email);
                            cmdKaryawan.Parameters.AddWithValue("@nohp", data.NoHp);
                            cmdKaryawan.Parameters.AddWithValue("@id_divisi", data.IdDivisi);
                            cmdKaryawan.Parameters.AddWithValue("@id_users", idUserBaru);
                            cmdKaryawan.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        // UPDATE: Perbarui data di tabel users dan karyawan
        public void UbahKaryawan(Karyawan data)
        {
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlUser = @"
                            UPDATE users SET username = @username, password_users = @password
                            WHERE id_users = @id_users;";

                        using (var cmdUser = new NpgsqlCommand(sqlUser, conn, trans))
                        {
                            cmdUser.Parameters.AddWithValue("@username", data.Username);
                            cmdUser.Parameters.AddWithValue("@password", data.PasswordUsers);
                            cmdUser.Parameters.AddWithValue("@id_users", data.IdUsers);
                            cmdUser.ExecuteNonQuery();
                        }

                        string sqlKaryawan = @"
                            UPDATE karyawan
                            SET nama_lengkap = @nama, nik = @nik, alamat = @alamat,
                                email = @email, nohp = @nohp, id_divisi = @id_divisi
                            WHERE id_karyawan = @id_karyawan;";

                        using (var cmdKaryawan = new NpgsqlCommand(sqlKaryawan, conn, trans))
                        {
                            cmdKaryawan.Parameters.AddWithValue("@nama", data.NamaLengkap);
                            cmdKaryawan.Parameters.AddWithValue("@nik", data.Nik);
                            cmdKaryawan.Parameters.AddWithValue("@alamat", data.Alamat);
                            cmdKaryawan.Parameters.AddWithValue("@email", data.Email);
                            cmdKaryawan.Parameters.AddWithValue("@nohp", data.NoHp);
                            cmdKaryawan.Parameters.AddWithValue("@id_divisi", data.IdDivisi);
                            cmdKaryawan.Parameters.AddWithValue("@id_karyawan", data.IdKaryawan);
                            cmdKaryawan.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        // DELETE: Hapus akun dari tabel users (tabel karyawan ikut terhapus otomatis karena ON DELETE CASCADE)
        public void HapusKaryawan(int idUsers)
        {
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM users WHERE id_users = @id_users AND is_pimpinan = FALSE;";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_users", idUsers);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}