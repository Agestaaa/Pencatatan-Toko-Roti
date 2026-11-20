using System;

namespace Windforms_Toko_Roti.Models
{
    public class DisplayRoti
    {
        private string _namaRoti;
        private decimal _harga;
        private int _stok;

        public int IdDisplay { get; set; }

        public string NamaRoti
        {
            get => _namaRoti;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nama roti tidak boleh kosong!");
                _namaRoti = value.Trim();
            }
        }

        public string Deskripsi { get; set; }

        public decimal Harga
        {
            get => _harga;
            set
            {
                if (value < 0)
                    throw new Exception("Harga roti tidak boleh negatif!");
                _harga = value;
            }
        }

        public int Stok
        {
            get => _stok;
            set
            {
                if (value < 0)
                    throw new Exception("Stok display tidak boleh kurang dari 0!");
                _stok = value;
            }
        }
    }
}