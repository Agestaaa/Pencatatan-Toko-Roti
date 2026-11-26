using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Windforms_Toko_Roti.Controllers;
using Windforms_Toko_Roti.Models;

namespace Windforms_Toko_Roti.Views
{
    public partial class DisplayOwner : Form
    {
        private readonly DisplayController _controller = new DisplayController();

        public DisplayOwner()
        {
            InitializeComponent();

            this.Load += Display_Owner_Load;
            btnRefresh.Click += (s, e) => MuatKartuDisplay();

            // Navigasi Sidebar
            btnDashboard.Click += btnDashboard_Click;
            btnAkunPekerja.Click += btnAkunPekerja_Click;
            btnPengeluaran.Click += btnPengeluaran_Click;
            btnPenjualan.Click += btnPenjualan_Click;
            btnStok.Click += btnStok_Click;
            btnDisplay.Click += (s, e) => MuatKartuDisplay();
            btnLogout.Click += btnLogout_Click;
        }

        private void Display_Owner_Load(object sender, EventArgs e)
        {
            MuatKartuDisplay();
        }

        private void MuatKartuDisplay()
        {
            try
            {
                flpDisplay.Controls.Clear();
                List<DisplayRoti> daftarRoti = _controller.GetAllDisplay();

                if (daftarRoti.Count == 0)
                {
                    Label lblKosong = new Label
                    {
                        Text = "Belum ada produk roti di etalase.\nSilakan minta Restocker untuk menambahkan data display.",
                        Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Padding = new Padding(20)
                    };
                    flpDisplay.Controls.Add(lblKosong);
                    return;
                }

                foreach (var item in daftarRoti)
                {
                    Panel card = BuatKartuProduk(item);
                    flpDisplay.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data display: " + ex.Message, "Error Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel BuatKartuProduk(DisplayRoti item)
        {
            Panel pnlCard = new Panel
            {
                BackColor = Color.FromArgb(237, 236, 214),
                Size = new Size(235, 275),
                Margin = new Padding(10, 10, 15, 15)
            };

            // Kotak Inisial / Gambar Produk
            Label lblIcon = new Label
            {
                BackColor = Color.FromArgb(250, 247, 248),
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = Color.FromArgb(210, 110, 145),
                Location = new Point(22, 18),
                Size = new Size(190, 105),
                Text = item.NamaRoti.Substring(0, 1).ToUpper(),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Nama Roti
            Label lblNama = new Label
            {
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(65, 55, 60),
                Location = new Point(12, 132),
                Size = new Size(210, 26),
                Text = item.NamaRoti,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Harga Jual
            Label lblHarga = new Label
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.FromArgb(95, 85, 90),
                Location = new Point(12, 160),
                Size = new Size(210, 24),
                Text = string.Format(new CultureInfo("id-ID"), "Rp. {0:N0}", item.Harga),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Deskripsi Singkat
            Label lblDesc = new Label
            {
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                ForeColor = Color.DimGray,
                Location = new Point(12, 188),
                Size = new Size(210, 38),
                Text = item.Deskripsi,
                TextAlign = ContentAlignment.TopCenter
            };

            // Stok Tersedia
            Label lblStok = new Label
            {
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = item.Stok <= 10 ? Color.Crimson : Color.MediumVioletRed,
                Location = new Point(12, 232),
                Size = new Size(210, 26),
                Text = $"Stok: {item.Stok} pcs",
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnlCard.Controls.Add(lblIcon);
            pnlCard.Controls.Add(lblNama);
            pnlCard.Controls.Add(lblHarga);
            pnlCard.Controls.Add(lblDesc);
            pnlCard.Controls.Add(lblStok);

            return pnlCard;
        }

        // --- Navigasi Antar Halaman ---
        private void PindahHalaman(Form formTujuan)
        {
            this.Hide();
            formTujuan.FormClosed += (s, args) => this.Close();
            formTujuan.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PindahHalaman(new FormDashboard());
        }

        private void btnAkunPekerja_Click(object sender, EventArgs e)
        {
            // Buka komentar di bawah ini jika FormAkunPekerja sudah ada di dalam project
            // PindahHalaman(new FormAkunPekerja());
            MessageBox.Show("Menu Akun Pekerja siap dihubungkan.");
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Pengeluaran belum dibuat.");
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Penjualan belum dibuat.");
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Stok Bahan Baku belum dibuat.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}