using System;

namespace Windforms_Toko_Roti.Models
{
    // Class induk (Parent Class) untuk akun login
    public class Pengguna
    {
        public int IdUsers { get; set; }
        public string Username { get; set; }
        public string PasswordUsers { get; set; }
        public bool IsPimpinan { get; set; }
    }

    // Class representasi tabel divisi
    public class Divisi
    {
        public int IdDivisi { get; set; }
        public string NamaDivisi { get; set; }
    }

    // Inheritance: Karyawan mewarisi atribut akun dari Pengguna
    public class Karyawan : Pengguna
    {
        private string _namaLengkap;
        private string _nik;

        public int IdKaryawan { get; set; }

        // Encapsulation: memvalidasi agar nama tidak kosong
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

        // Encapsulation: memvalidasi batas panjang NIK sesuai DDL varchar(18)
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

        // Relasi dengan tabel divisi
        public int IdDivisi { get; set; }
        public string NamaDivisi { get; set; }

        public Karyawan()
        {
            IsPimpinan = false; // Pekerja bukan Owner
        }
    }
}