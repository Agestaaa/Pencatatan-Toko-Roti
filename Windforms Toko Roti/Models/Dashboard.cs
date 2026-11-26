using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windforms_Toko_Roti.Models
{
    public class Dashboard
    {
        public decimal TotalPendapatan { get; set; }
        public int TotalTransaksiPenjualan { get; set; }
        public decimal TotalPengeluaran { get; set; }
        public int TotalPekerja { get; set; }
        public int PekerjaHadirHariIni { get; set; }
        public int TotalStokRoti { get; set; }
        public int BahanMenipis { get; set; }

        public decimal LabaBersih => TotalPendapatan - TotalPengeluaran;
    }
}
