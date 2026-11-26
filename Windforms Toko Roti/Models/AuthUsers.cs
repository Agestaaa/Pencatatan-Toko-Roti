using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windforms_Toko_Roti.Views;

namespace Windforms_Toko_Roti.Models
{
    public abstract class Users
    {
        private string _username;
        private string _passwordUsers;

        public int IdUsers { get; set; }

        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username wajib diisi.");
                _username = value.Trim();
            }
        }

        public string PasswordUsers
        {
            get => _passwordUsers;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Password wajib diisi.");
                _passwordUsers = value;
            }
        }

        public bool IsPimpinan { get; set; }
        public string NamaLengkap { get; set; }
        public string NamaDivisi { get; set; }

        // Polymorphism: setiap role menentukan form tujuan masing-masing
        public abstract Form BuatHalamanUtama();
    }

    // Turunan 1: Akun Owner (is_pimpinan = true)
    public class AkunOwner : Users
    {
        public AkunOwner()
        {
            IsPimpinan = true;
            NamaDivisi = "Owner";
        }

        public override Form BuatHalamanUtama()
        {
            return new FormUtamaOwner();
        }
    }

    // Turunan 2: Akun Pekerja (Baker, Kasir, Restocker -> is_pimpinan = false)
    public class AkunKaryawan : Users
    {
        public int IdKaryawan { get; set; }

        public AkunKaryawan()
        {
            IsPimpinan = false;
        }

        public override Form BuatHalamanUtama()
        {
            // Sementara diarahkan ke FormAkunKaryawan / sesuaikan dengan form masing-masing divisi nanti:
            // if (NamaDivisi == "Kasir") return new FormPenjualanKasir();
            // if (NamaDivisi == "Baker") return new FormStokBaker();
            // if (NamaDivisi == "Restocker") return new FormDisplayRestocker();
            return new FormAkunKaryawan();
        }
    }
}
