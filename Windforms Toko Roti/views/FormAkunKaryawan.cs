using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windforms_Toko_Roti.Controllers;
using Windforms_Toko_Roti.Models;

namespace Windforms_Toko_Roti.Views
{
    public partial class FormAkunKaryawan : Form
    {
        private readonly KaryawanController _controller = new KaryawanController();
        private List<Karyawan> _listKaryawan = new List<Karyawan>();
        private int _selectedIdKaryawan = 0;
        private int _selectedIdUsers = 0;

        public FormAkunKaryawan()
        {
            InitializeComponent();

            this.Load += FormAkunPekerja_Load;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnReset.Click += btnReset_Click;
            dgvKaryawan.CellClick += dgvKaryawan_CellClick;
        }

        private void FormAkunPekerja_Load(object sender, EventArgs e)
        {
            MuatDivisi();
            MuatDataTabel();
        }

        private void MuatDivisi()
        {
            cmbDivisi.DisplayMember = "NamaDivisi";
            cmbDivisi.ValueMember = "IdDivisi";
            cmbDivisi.DataSource = _controller.GetAllDivisi();
        }

        private void MuatDataTabel()
        {
            _listKaryawan = _controller.GetAllKaryawan();
            dgvKaryawan.DataSource = null;
            dgvKaryawan.DataSource = _listKaryawan;

            if (dgvKaryawan.Columns["IdKaryawan"] != null) dgvKaryawan.Columns["IdKaryawan"].Visible = false;
            if (dgvKaryawan.Columns["IdUsers"] != null) dgvKaryawan.Columns["IdUsers"].Visible = false;
            if (dgvKaryawan.Columns["IdDivisi"] != null) dgvKaryawan.Columns["IdDivisi"].Visible = false;
            if (dgvKaryawan.Columns["IsPimpinan"] != null) dgvKaryawan.Columns["IsPimpinan"].Visible = false;
            if (dgvKaryawan.Columns["PasswordUsers"] != null) dgvKaryawan.Columns["PasswordUsers"].Visible = false;
        }

        private void ResetForm()
        {
            _selectedIdKaryawan = 0;
            _selectedIdUsers = 0;
            txtNama.Clear();
            txtNik.Clear();
            txtNoHp.Clear();
            txtEmail.Clear();
            txtAlamat.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            if (cmbDivisi.Items.Count > 0) cmbDivisi.SelectedIndex = 0;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                var pekerjaBaru = new Karyawan
                {
                    NamaLengkap = txtNama.Text,
                    Nik = txtNik.Text,
                    NoHp = txtNoHp.Text,
                    Email = txtEmail.Text,
                    Alamat = txtAlamat.Text,
                    IdDivisi = Convert.ToInt32(cmbDivisi.SelectedValue),
                    Username = txtUsername.Text,
                    PasswordUsers = txtPassword.Text
                };

                _controller.TambahKaryawan(pekerjaBaru);
                MessageBox.Show("Pekerja berhasil ditambahkan!");
                ResetForm();
                MuatDataTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (_selectedIdKaryawan == 0)
            {
                MessageBox.Show("Klik salah satu baris di tabel terlebih dahulu.");
                return;
            }

            try
            {
                var pekerjaEdit = new Karyawan
                {
                    IdKaryawan = _selectedIdKaryawan,
                    IdUsers = _selectedIdUsers,
                    NamaLengkap = txtNama.Text,
                    Nik = txtNik.Text,
                    NoHp = txtNoHp.Text,
                    Email = txtEmail.Text,
                    Alamat = txtAlamat.Text,
                    IdDivisi = Convert.ToInt32(cmbDivisi.SelectedValue),
                    Username = txtUsername.Text,
                    PasswordUsers = txtPassword.Text
                };

                _controller.UbahKaryawan(pekerjaEdit);
                MessageBox.Show("Data pekerja berhasil diubah!");
                ResetForm();
                MuatDataTabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedIdUsers == 0)
            {
                MessageBox.Show("Klik salah satu baris di tabel terlebih dahulu.");
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus akun ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _controller.HapusKaryawan(_selectedIdUsers);
                MessageBox.Show("Akun berhasil dihapus!");
                ResetForm();
                MuatDataTabel();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var terpilih = _listKaryawan[e.RowIndex];
            _selectedIdKaryawan = terpilih.IdKaryawan;
            _selectedIdUsers = terpilih.IdUsers;

            txtNama.Text = terpilih.NamaLengkap;
            txtNik.Text = terpilih.Nik;
            txtNoHp.Text = terpilih.NoHp;
            txtEmail.Text = terpilih.Email;
            txtAlamat.Text = terpilih.Alamat;
            txtUsername.Text = terpilih.Username;
            txtPassword.Text = terpilih.PasswordUsers;
            cmbDivisi.SelectedValue = terpilih.IdDivisi;
        }
    }
}