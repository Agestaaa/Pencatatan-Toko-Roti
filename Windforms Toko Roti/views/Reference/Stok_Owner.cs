using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Windforms_Toko_Roti.Controllers;
using Windforms_Toko_Roti.Views;

namespace Windforms_Toko_Roti
{
    public partial class Stok_Owner : Form
    {
        private readonly StokController _stokController;

        public Stok_Owner()
        {
            InitializeComponent();
            _stokController = new StokController();

            this.Load += Stok_Owner_Load;

            // Navigasi Sidebar
            this.button2.Click += (s, e) => PindahHalaman(new dashboard_owner());
            this.button1.Click += (s, e) => MuatDataStok();
            this.button6.Click += (s, e) => PindahHalaman(new DisplayOwner());
        }

        private void PindahHalaman(Form formTujuan)
        {
            this.Hide();
            formTujuan.FormClosed += (s, args) => this.Close();
            formTujuan.Show();
        }

        private void Stok_Owner_Load(object sender, EventArgs e)
        {
            AturTampilanTabel();
            MuatDataStok();
        }

        private void AturTampilanTabel()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 145, 171);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.RowTemplate.Height = 28;
        }

        private void MuatDataStok()
        {
            try
            {
                var dataStok = _stokController.GetAllStok();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataStok;

                if (dataGridView1.Columns["IdStokBahanBaku"] != null)
                    dataGridView1.Columns["IdStokBahanBaku"].Visible = false;
                if (dataGridView1.Columns["BeratSatuan"] != null)
                    dataGridView1.Columns["BeratSatuan"].Visible = false;
                if (dataGridView1.Columns["NamaSatuan"] != null)
                    dataGridView1.Columns["NamaSatuan"].Visible = false;

                if (dataGridView1.Columns["NamaBahan"] != null)
                    dataGridView1.Columns["NamaBahan"].HeaderText = "Nama Bahan Baku";

                if (dataGridView1.Columns["Harga"] != null)
                {
                    dataGridView1.Columns["Harga"].HeaderText = "Harga";
                    dataGridView1.Columns["Harga"].DefaultCellStyle.Format = "Rp #,##0";
                    dataGridView1.Columns["Harga"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                }

                if (dataGridView1.Columns["Kuantitas"] != null)
                    dataGridView1.Columns["Kuantitas"].HeaderText = "Kuantitas";

                if (dataGridView1.Columns["Kelipatan"] != null)
                    dataGridView1.Columns["Kelipatan"].HeaderText = "Kelipatan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok bahan baku: " + ex.Message,
                    "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}