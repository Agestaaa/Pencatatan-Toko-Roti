using Windforms_Toko_Roti.Database;
using Windforms_Toko_Roti.Models;
using Npgsql;
using System;
using System.Data;
using System.Data.Common;

namespace Windforms_Toko_Roti.Controllers
{
    public class DashboardController
    {
        public Dashboard GetSummary()
        {
            var summary = new Dashboard();

            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();

                summary.TotalPendapatan = ExecuteDecimal(conn, @"
                    SELECT COALESCE(SUM(dp.jumlah * d.harga), 0)
                    FROM detail_penjualan dp
                    INNER JOIN display d ON dp.id_display = d.id_display;");

                summary.TotalTransaksiPenjualan = ExecuteInt(conn,
                    "SELECT COUNT(*) FROM penjualan;");

                summary.TotalPengeluaran = ExecuteDecimal(conn,
                    "SELECT COALESCE(SUM(harga_satuan * kuantitas), 0) FROM detail_pengeluaran;");

                summary.TotalPekerja = ExecuteInt(conn, @"
                    SELECT COUNT(*)
                    FROM karyawan k
                    INNER JOIN users u ON k.id_users = u.id_users
                    WHERE u.is_pimpinan = FALSE;");

                summary.PekerjaHadirHariIni = ExecuteInt(conn, @"
                    SELECT COUNT(*)
                    FROM kehadiran
                    WHERE DATE(tanggal) = CURRENT_DATE AND status = 'Hadir';");

                summary.TotalStokRoti = ExecuteInt(conn,
                    "SELECT COALESCE(SUM(stok), 0) FROM display;");

                summary.BahanMenipis = ExecuteInt(conn,
                    "SELECT COUNT(*) FROM stok_bahan_baku WHERE stok <= 10;");
            }

            return summary;
        }

        // 2. Data Tab Penjualan
        public DataTable GetDataPenjualan()
        {
            string sql = @"
                SELECT 
                    p.id_penjualan AS ""ID"",
                    TO_CHAR(p.tanggal, 'DD/MM/YYYY HH24:MI') AS ""Tanggal"",
                    d.nama_roti AS ""Nama Roti"",
                    dp.jumlah AS ""Jumlah"",
                    d.harga AS ""Harga Satuan"",
                    (dp.jumlah * d.harga) AS ""Subtotal""
                FROM detail_penjualan dp
                INNER JOIN penjualan p ON dp.id_penjualan = p.id_penjualan
                INNER JOIN display d ON dp.id_display = d.id_display
                ORDER BY p.tanggal DESC, p.id_penjualan DESC;";

            return ExecuteTable(sql);
        }

        // 3. Data Tab Pengeluaran
        public DataTable GetDataPengeluaran()
        {
            string sql = @"
                SELECT 
                    pg.id_pengeluaran AS ""ID"",
                    TO_CHAR(pg.tanggal, 'DD/MM/YYYY HH24:MI') AS ""Tanggal"",
                    sb.nama_bahan AS ""Bahan Baku"",
                    dp.kuantitas AS ""Qty"",
                    dp.berat_satuan AS ""Berat Satuan"",
                    dp.harga_satuan AS ""Harga Satuan"",
                    (dp.kuantitas * dp.harga_satuan) AS ""Total"",
                    CASE WHEN pg.status THEN 'Disetujui' ELSE 'Pending' END AS ""Status"",
                    CASE WHEN pg.sampaai THEN 'Sampai' ELSE 'Belum Sampai' END AS ""Pengiriman""
                FROM detail_pengeluaran dp
                INNER JOIN pengeluaran pg ON dp.id_pengeluaran = pg.id_pengeluaran
                INNER JOIN stok_bahan_baku sb ON dp.id_stok_bahan_baku = sb.id_stok_bahan_baku
                ORDER BY pg.tanggal DESC, pg.id_pengeluaran DESC;";

            return ExecuteTable(sql);
        }

        // 4. Data Tab Stok Bahan Baku
        public DataTable GetDataStokBahan()
        {
            string sql = @"
                SELECT 
                    sb.id_stok_bahan_baku AS ""ID"",
                    sb.nama_bahan AS ""Nama Bahan Baku"",
                    sb.stok AS ""Stok Tersedia"",
                    COALESCE(s.nama_satuan, '-') AS ""Satuan"",
                    CASE WHEN sb.stok <= 10 THEN 'Menipis' ELSE 'Aman' END AS ""Kondisi""
                FROM stok_bahan_baku sb
                LEFT JOIN satuan s ON sb.id_satuan = s.id_satuan
                ORDER BY sb.stok ASC, sb.nama_bahan ASC;";

            return ExecuteTable(sql);
        }

        // 5. Data Tab Display Roti
        public DataTable GetDataDisplayRoti()
        {
            string sql = @"
                SELECT 
                    id_display AS ""ID"",
                    nama_roti AS ""Nama Roti"",
                    deskripsi AS ""Deskripsi"",
                    harga AS ""Harga Jual"",
                    stok AS ""Stok Display""
                FROM display
                ORDER BY nama_roti ASC;";

            return ExecuteTable(sql);
        }

        // 6. Data Tab Riwayat Produksi
        public DataTable GetDataProduksi()
        {
            string sql = @"
                SELECT 
                    pr.id_produksi AS ""ID"",
                    TO_CHAR(pr.tanggal, 'DD/MM/YYYY HH24:MI') AS ""Tanggal Produksi"",
                    d.nama_roti AS ""Nama Roti"",
                    pr.kuantitas_produksi AS ""Jumlah Produksi""
                FROM produksi pr
                INNER JOIN display d ON pr.id_display = d.id_display
                ORDER BY pr.tanggal DESC, pr.id_produksi DESC;";

            return ExecuteTable(sql);
        }

        // 7. Data Tab Kehadiran Pekerja
        public DataTable GetDataKehadiran()
        {
            string sql = @"
                SELECT 
                    kh.id_kehadiran AS ""ID"",
                    TO_CHAR(kh.tanggal, 'DD/MM/YYYY HH24:MI') AS ""Waktu Presensi"",
                    k.nama_lengkap AS ""Nama Pekerja"",
                    COALESCE(dv.nama_divisi, '-') AS ""Divisi"",
                    kh.status::text AS ""Status""
                FROM kehadiran kh
                INNER JOIN users u ON kh.id_users = u.id_users
                INNER JOIN karyawan k ON u.id_users = k.id_users
                LEFT JOIN divisi dv ON k.id_divisi = dv.id_divisi
                ORDER BY kh.tanggal DESC, kh.id_kehadiran DESC;";

            return ExecuteTable(sql);
        }

        // Helper internal agar kode tidak berulang
        private DataTable ExecuteTable(string sql)
        {
            var dt = new DataTable();
            using (var conn = NYAMBUNG.GetConnection())
            {
                conn.Open();
                using (var adapter = new NpgsqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        private int ExecuteInt(NpgsqlConnection conn, string sql)
        {
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private decimal ExecuteDecimal(NpgsqlConnection conn, string sql)
        {
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}