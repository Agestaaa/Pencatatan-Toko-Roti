using System;
using System.Windows.Forms;
using Windforms_Toko_Roti.Controllers;

namespace Windforms_Toko_Roti.Views
{
    public partial class Login : Form
    {
        private readonly AuthController _authController;

        public Login()
        {
            InitializeComponent();
            _authController = new AuthController();

            btnLogin.Click += btnLogin_Click;
            btnClose.Click += btnClose_Click;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogin.Text = "MEMPROSES...";

            var hasil = _authController.ProsesLogin(txtUsername.Text, txtPassword.Text);

            btnLogin.Enabled = true;
            btnLogin.Text = "MASUK";

            if (hasil.Sukses && hasil.Pengguna != null)
            {
                MessageBox.Show(hasil.Pesan, "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Polymorphism: memanggil BuatHalamanUtama() sesuai jenis akun (Owner atau Pekerja)
                Form halamanTujuan = hasil.Pengguna.BuatHalamanUtama();
                halamanTujuan.FormClosed += (s, args) =>
                {
                    txtPassword.Clear();
                    this.Show();
                    txtUsername.Focus();
                };

                this.Hide();
                halamanTujuan.Show();
            }
            else
            {
                MessageBox.Show(hasil.Pesan, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}