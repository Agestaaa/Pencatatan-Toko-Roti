using System;

namespace Windforms_Toko_Roti.Models
{
    public class Pengguna
    {
        public int IdUsers { get; set; }
        public string Username { get; set; }
        public string PasswordUsers { get; set; }
        public bool IsPimpinan { get; set; }
    }

    public class Divisi
    {
        public int IdDivisi { get; set; }
        public string NamaDivisi { get; set; }
    }

    public class Karyawan : Pengguna
    {
        private string _namaLengkap;
        private string _nik;

        public int IdKaryawan { get; set; }

        public string NamaLengkap
        {
            get => _namaLengkap;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nama lengkap tidak boleh kosong!");
                _namaLengkap = value.Trim();
            }
        }

        public string Nik
        {
            get => _nik;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 18)
                    throw new Exception("NIK wajib diisi dan maksimal 18 karakter!");
                _nik = value.Trim();
            }
        }

        public string Alamat { get; set; }
        public string Email { get; set; }
        public string NoHp { get; set; }


        public int IdDivisi { get; set; }
        public string NamaDivisi { get; set; }

        public Karyawan()
        {
            IsPimpinan = false; 
        }
    }
}