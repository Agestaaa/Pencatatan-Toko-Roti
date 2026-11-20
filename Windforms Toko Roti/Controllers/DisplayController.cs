using Windforms_Toko_Roti.Database;
using Windforms_Toko_Roti.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Windforms_Toko_Roti.Controllers
{
    public class DisplayController
    {
        public List<DisplayRoti> GetAllDisplay()
        {
            var list = new List<DisplayRoti>();
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT id_display, nama_roti, deskripsi, harga, stok 
                    FROM display 
                    ORDER BY id_display ASC;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DisplayRoti
                        {
                            IdDisplay = Convert.ToInt32(reader["id_display"]),
                            NamaRoti = reader["nama_roti"].ToString(),
                            Deskripsi = reader["deskripsi"].ToString(),
                            Harga = Convert.ToDecimal(reader["harga"]),
                            Stok = Convert.ToInt32(reader["stok"])
                        });
                    }
                }
            }
            return list;
        }

        public void TambahDisplay(DisplayRoti data)
        {
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO display (nama_roti, deskripsi, harga, stok)
                    VALUES (@nama, @deskripsi, @harga, @stok);";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", data.NamaRoti);
                    cmd.Parameters.AddWithValue("@deskripsi", data.Deskripsi ?? "-");
                    cmd.Parameters.AddWithValue("@harga", data.Harga);
                    cmd.Parameters.AddWithValue("@stok", data.Stok);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UbahDisplay(DisplayRoti data)
        {
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE display 
                    SET nama_roti = @nama, deskripsi = @deskripsi, harga = @harga, stok = @stok
                    WHERE id_display = @id;";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", data.NamaRoti);
                    cmd.Parameters.AddWithValue("@deskripsi", data.Deskripsi ?? "-");
                    cmd.Parameters.AddWithValue("@harga", data.Harga);
                    cmd.Parameters.AddWithValue("@stok", data.Stok);
                    cmd.Parameters.AddWithValue("@id", data.IdDisplay);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void HapusDisplay(int idDisplay)
        {
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM display WHERE id_display = @id;";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDisplay);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}