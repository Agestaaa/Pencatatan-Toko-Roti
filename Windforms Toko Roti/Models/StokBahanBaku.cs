using System;
using System.Globalization;

namespace Windforms_Toko_Roti.Models
{
    public class StokBahanBaku
    {
        private string _namaBahan;
        private decimal _harga;
        private int _kuantitas;
        private decimal _beratSatuan;

        public int IdStokBahanBaku { get; set; }

        public string NamaBahan
        {
            get => _namaBahan;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama bahan baku tidak boleh kosong.");
                _namaBahan = value.Trim();
            }
        }

        public decimal Harga
        {
            get => _harga;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga tidak boleh kurang dari 0.");
                _harga = value;
            }
        }

        public int Kuantitas
        {
            get => _kuantitas;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Kuantitas tidak boleh kurang dari 0.");
                _kuantitas = value;
            }
        }

        public decimal BeratSatuan
        {
            get => _beratSatuan;
            set => _beratSatuan = value > 0 ? value : 1;
        }

        public string NamaSatuan { get; set; }

        // Otomatis memformat kelipatan sesuai budaya Indonesia (koma desimal), misal: "Per 1,5 Kg"
        public string Kelipatan
        {
            get
            {
                string angka = BeratSatuan.ToString("0.##", new CultureInfo("id-ID"));
                return $"Per {angka} {NamaSatuan}";
            }
        }
    }
}