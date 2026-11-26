using Windforms_Toko_Roti.Controllers;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Windforms_Toko_Roti.Controllers;

namespace Windforms_Toko_Roti.Views
{
    public partial class FormDashboard : Form
    {
        private readonly DashboardController _controller = new DashboardController();
        private readonly CultureInfo _cultureId = new CultureInfo("id-ID");

        public FormDashboard()
        {
            InitializeComponent();

            TerapkanTemaTabel(dgvPenjualan);
            TerapkanTemaTabel(dgvPengeluaran);
            TerapkanTemaTabel(dgvStokBahan);
            TerapkanTemaTabel(dgvDisplay);
            TerapkanTemaTabel(dgvProduksi);
            TerapkanTemaTabel(dgvKehadiran);

            this.Load += (s, e) => MuatSemuaData();
            btnRefresh.Click += (s, e) => MuatSemuaData();
        }

        private void MuatSemuaData()
        {
            try
            {
                var ringkasan = _controller.GetSummary();

                lblPendapatan.Text = FormatRupiah(ringkasan.TotalPendapatan);
                lblSubPendapatan.Text = $"{ringkasan.TotalTransaksiPenjualan} transaksi";

                lblPengeluaran.Text = FormatRupiah(ringkasan.TotalPengeluaran);
                lblSubLaba.Text = $"Laba: {FormatRupiah(ringkasan.LabaBersih)}";

                lblPekerja.Text = $"{ringkasan.TotalPekerja}";
                lblSubHadir.Text = $"Hadir: {ringkasan.PekerjaHadirHariIni} orang";

                lblStokRoti.Text = $"{ringkasan.TotalStokRoti}";
                lblSubBahan.Text = $"Bahan menipis: {ringkasan.BahanMenipis} item";

                // 2. Muat 6 Tabel Data Operasional
                dgvPenjualan.DataSource = _controller.GetDataPenjualan();
                dgvPengeluaran.DataSource = _controller.GetDataPengeluaran();
                dgvStokBahan.DataSource = _controller.GetDataStokBahan();
                dgvDisplay.DataSource = _controller.GetDataDisplayRoti();
                dgvProduksi.DataSource = _controller.GetDataProduksi();
                dgvKehadiran.DataSource = _controller.GetDataKehadiran();

                // 3. Format kolom mata uang agar rapi
                FormatKolomRupiah(dgvPenjualan, "Harga Satuan", "Subtotal");
                FormatKolomRupiah(dgvPengeluaran, "Harga Satuan", "Total");
                FormatKolomRupiah(dgvDisplay, "Harga Jual");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatRupiah(decimal nominal)
        {
            return string.Format(_cultureId, "Rp {0:N0}", nominal);
        }

        private void FormatKolomRupiah(DataGridView dgv, params string[] namaKolom)
        {
            foreach (var kolom in namaKolom)
            {
                if (dgv.Columns[kolom] != null)
                {
                    dgv.Columns[kolom].DefaultCellStyle.Format = "C0";
                    dgv.Columns[kolom].DefaultCellStyle.FormatProvider = _cultureId;
                }
            }
        }

        private void TerapkanTemaTabel(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(242, 234, 238);
            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.RowTemplate.Height = 28;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 145, 171);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(65, 55, 60);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 224, 232);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(65, 55, 60);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 246, 249);
        }

        private void pnlCardStok_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}