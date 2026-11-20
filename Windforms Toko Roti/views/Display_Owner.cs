using Windforms_Toko_Roti.Controllers;
using Windforms_Toko_Roti.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Windforms_Toko_Roti.Views
{
    public partial class Display_Owner : Form
    {
        private readonly DisplayController _controller = new DisplayController();
        private int _selectedIdDisplay = 0;

        public Display_Owner()
        {
            InitializeComponent();

            this.Load += Display_Owner_Load;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnReset.Click += btnReset_Click;
            btnAkunPekerja.Click += btnAkunPekerja_Click;
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
                BackColor = Color.FromArgb(237, 236, 214), // Krem khas Cloud Bakery
                Size = new Size(186, 235),
                Margin = new Padding(6, 6, 10, 10),
                Cursor = Cursors.Hand,
                Tag = item
            };

            // Kotak ilustrasi/ikon di bagian atas kartu
            Label lblIcon = new Label
            {
                BackColor = Color.FromArgb(250, 247, 248),
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(210, 110, 145),
                Location = new Point(18, 14),
                Size = new Size(150, 88),
                Text = item.NamaRoti.Substring(0, 1).ToUpper(),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblNama = new Label
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(65, 55, 60),
                Location = new Point(10, 110),
                Size = new Size(166, 24),
                Text = item.NamaRoti,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblHarga = new Label
            {
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(95, 85, 90),
                Location = new Point(10, 136),
                Size = new Size(166, 22),
                Text = string.Format(new CultureInfo("id-ID"), "Rp {0:N0}", item.Harga),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblDesc = new Label
            {
                Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(10, 160),
                Size = new Size(166, 30),
                Text = item.Deskripsi,
                TextAlign = ContentAlignment.TopCenter
            };

            Label lblStok = new Label
            {
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = item.Stok <= 10 ? Color.Crimson : Color.MediumVioletRed,
                Location = new Point(10, 198),
                Size = new Size(166, 24),
                Text = $"Stok: {item.Stok}",
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Event klik pada kartu maupun label di dalamnya agar memilih produk
            EventHandler pilihProduk = (s, e) => PilihKartu(item);
            pnlCard.Click += pilihProduk;
            lblIcon.Click += pilihProduk;
            lblNama.Click += pilihProduk;
            lblHarga.Click += pilihProduk;
            lblDesc.Click += pilihProduk;
            lblStok.Click += pilihProduk;

            pnlCard.Controls.Add(lblIcon);
            pnlCard.Controls.Add(lblNama);
            pnlCard.Controls.Add(lblHarga);
            pnlCard.Controls.Add(lblDesc);
            pnlCard.Controls.Add(lblStok);

            return pnlCard;
        }

        private void PilihKartu(DisplayRoti item)
        {
            _selectedIdDisplay = item.IdDisplay;
            txtNamaRoti.Text = item.NamaRoti;
            numHarga.Value = item.Harga;
            numStok.Value = item.Stok;
            txtDeskripsi.Text = item.Deskripsi;
        }

        private void ResetForm()
        {
            _selectedIdDisplay = 0;
            txtNamaRoti.Clear();
            numHarga.Value = 0;
            numStok.Value = 0;
            txtDeskripsi.Clear();
            txtNamaRoti.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                var rotiBaru = new DisplayRoti
                {
                    NamaRoti = txtNamaRoti.Text,
                    Harga = numHarga.Value,
                    Stok = (int)numStok.Value,
                    Deskripsi = txtDeskripsi.Text
                };

                _controller.TambahDisplay(rotiBaru);
                MessageBox.Show("Produk roti berhasil ditambahkan ke display!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                MuatKartuDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah produk: " + ex.Message, "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (_selectedIdDisplay == 0)
            {
                MessageBox.Show("Klik salah satu kartu roti di bawah terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var rotiEdit = new DisplayRoti
                {
                    IdDisplay = _selectedIdDisplay,
                    NamaRoti = txtNamaRoti.Text,
                    Harga = numHarga.Value,
                    Stok = (int)numStok.Value,
                    Deskripsi = txtDeskripsi.Text
                };

                _controller.UbahDisplay(rotiEdit);
                MessageBox.Show("Data produk display berhasil diperbarui!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                MuatKartuDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah produk: " + ex.Message, "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedIdDisplay == 0)
            {
                MessageBox.Show("Klik salah satu kartu roti yang ingin dihapus.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Yakin ingin menghapus '{txtNamaRoti.Text}' dari display?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.HapusDisplay(_selectedIdDisplay);
                MessageBox.Show("Produk berhasil dihapus dari display!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                MuatKartuDisplay();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAkunPekerja_Click(object sender, EventArgs e)
        {
            var formPekerja = new FormAkunKaryawan();
            formPekerja.ShowDialog();
        }
    }
}