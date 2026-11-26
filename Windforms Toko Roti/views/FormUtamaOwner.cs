using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windforms_Toko_Roti.Views
{
    public partial class FormUtamaOwner : Form
    {
        public FormUtamaOwner()
        {
            InitializeComponent();

            btnDashboard.Click += (s, e) => BukaHalaman(new FormDashboard(), btnDashboard);
            btnAkunPekerja.Click += (s, e) => BukaHalaman(new FormAkunKaryawan(), btnAkunPekerja);
            btnLogout.Click += (s, e) => this.Close();

            this.Load += (s, e) => BukaHalaman(new FormDashboard(), btnDashboard);
        }

        private void BukaHalaman(Form formAnak, Button tombolAktif)
        {
            btnDashboard.BackColor = Color.Transparent;
            btnAkunPekerja.BackColor = Color.Transparent;
            btnPengeluaran.BackColor = Color.Transparent;
            btnPenjualan.BackColor = Color.Transparent;
            btnStokBahan.BackColor = Color.Transparent;
            btnDisplay.BackColor = Color.Transparent;

            tombolAktif.BackColor = Color.FromArgb(199, 108, 140);

            // Tanamkan form anak ke dalam pnlKonten
            pnlKonten.Controls.Clear();
            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;
            pnlKonten.Controls.Add(formAnak);
            formAnak.Show();
        }
    }
}