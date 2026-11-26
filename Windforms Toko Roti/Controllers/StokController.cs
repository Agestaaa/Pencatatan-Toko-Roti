using System;
using System.Collections.Generic;
using Npgsql;
using Windforms_Toko_Roti.Database;
using Windforms_Toko_Roti.Models;

namespace Windforms_Toko_Roti.Controllers
{
    public class StokController
    {
        public List<StokBahanBaku> GetAllStok()
        {
            var daftarStok = new List<StokBahanBaku>();

            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        s.id_stok_bahan_baku,
                        s.nama_bahan,
                        s.stok AS kuantitas,
                        COALESCE(dp.harga_satuan, 0) AS harga_satuan,
                        COALESCE(dp.berat_satuan, 1) AS berat_satuan,
                        COALESCE(sa.nama_satuan, 'Kg') AS nama_satuan
                    FROM stok_bahan_baku s
                    LEFT JOIN satuan sa ON s.id_satuan = sa.id_satuan
                    LEFT JOIN (
                        SELECT DISTINCT ON (id_stok_bahan_baku)
                            id_stok_bahan_baku,
                            harga_satuan,
                            berat_satuan
                        FROM detail_pengeluaran
                        ORDER BY id_stok_bahan_baku, id_detail_pengeluaran DESC
                    ) dp ON s.id_stok_bahan_baku = dp.id_stok_bahan_baku
                    ORDER BY s.id_stok_bahan_baku ASC;";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        daftarStok.Add(new StokBahanBaku
                        {
                            IdStokBahanBaku = Convert.ToInt32(reader["id_stok_bahan_baku"]),
                            NamaBahan = reader["nama_bahan"].ToString(),
                            Harga = Convert.ToDecimal(reader["harga_satuan"]),
                            Kuantitas = Convert.ToInt32(reader["kuantitas"]),
                            BeratSatuan = Convert.ToDecimal(reader["berat_satuan"]),
                            NamaSatuan = reader["nama_satuan"].ToString()
                        });
                    }
                }
            }

            return daftarStok;
        }
    }
}