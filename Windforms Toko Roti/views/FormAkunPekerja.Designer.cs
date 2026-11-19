namespace Windforms_Toko_Roti.Views
{
    partial class FormAkunPekerja
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAltRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNik = new System.Windows.Forms.Label();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.lblDivisi = new System.Windows.Forms.Label();
            this.cmbDivisi = new System.Windows.Forms.ComboBox();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvKaryawan = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.pnlTop.Controls.Add(this.lblJudul);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 56);
            this.pnlTop.TabIndex = 0;

            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 14);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(344, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Cloud Bakery - Kelola Akun Pekerja";

            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.btnReset);
            this.pnlInput.Controls.Add(this.btnHapus);
            this.pnlInput.Controls.Add(this.btnUbah);
            this.pnlInput.Controls.Add(this.btnTambah);
            this.pnlInput.Controls.Add(this.txtPassword);
            this.pnlInput.Controls.Add(this.lblPassword);
            this.pnlInput.Controls.Add(this.txtUsername);
            this.pnlInput.Controls.Add(this.lblUsername);
            this.pnlInput.Controls.Add(this.txtAlamat);
            this.pnlInput.Controls.Add(this.lblAlamat);
            this.pnlInput.Controls.Add(this.txtEmail);
            this.pnlInput.Controls.Add(this.lblEmail);
            this.pnlInput.Controls.Add(this.txtNoHp);
            this.pnlInput.Controls.Add(this.lblNoHp);
            this.pnlInput.Controls.Add(this.cmbDivisi);
            this.pnlInput.Controls.Add(this.lblDivisi);
            this.pnlInput.Controls.Add(this.txtNik);
            this.pnlInput.Controls.Add(this.lblNik);
            this.pnlInput.Controls.Add(this.txtNama);
            this.pnlInput.Controls.Add(this.lblNama);
            this.pnlInput.Location = new System.Drawing.Point(20, 72);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(880, 245);
            this.pnlInput.TabIndex = 1;

            // 
            // lblNama & txtNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblNama.Location = new System.Drawing.Point(16, 14);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(108, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Lengkap";

            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtNama.Location = new System.Drawing.Point(16, 36);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(270, 29);
            this.txtNama.TabIndex = 1;

            // 
            // lblNik & txtNik
            // 
            this.lblNik.AutoSize = true;
            this.lblNik.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblNik.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblNik.Location = new System.Drawing.Point(306, 14);
            this.lblNik.Name = "lblNik";
            this.lblNik.Size = new System.Drawing.Size(34, 20);
            this.lblNik.TabIndex = 2;
            this.lblNik.Text = "NIK";

            this.txtNik.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtNik.Location = new System.Drawing.Point(306, 36);
            this.txtNik.MaxLength = 18;
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(250, 29);
            this.txtNik.TabIndex = 3;

            // 
            // lblDivisi & cmbDivisi
            // 
            this.lblDivisi.AutoSize = true;
            this.lblDivisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblDivisi.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblDivisi.Location = new System.Drawing.Point(576, 14);
            this.lblDivisi.Name = "lblDivisi";
            this.lblDivisi.Size = new System.Drawing.Size(85, 20);
            this.lblDivisi.TabIndex = 4;
            this.lblDivisi.Text = "Divisi / Role";

            this.cmbDivisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivisi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.cmbDivisi.FormattingEnabled = true;
            this.cmbDivisi.Location = new System.Drawing.Point(576, 36);
            this.cmbDivisi.Name = "cmbDivisi";
            this.cmbDivisi.Size = new System.Drawing.Size(286, 29);
            this.cmbDivisi.TabIndex = 5;

            // 
            // lblNoHp & txtNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblNoHp.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblNoHp.Location = new System.Drawing.Point(16, 74);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(56, 20);
            this.lblNoHp.TabIndex = 6;
            this.lblNoHp.Text = "No. HP";

            this.txtNoHp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtNoHp.Location = new System.Drawing.Point(16, 96);
            this.txtNoHp.MaxLength = 15;
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(200, 29);
            this.txtNoHp.TabIndex = 7;

            // 
            // lblEmail & txtEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblEmail.Location = new System.Drawing.Point(236, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtEmail.Location = new System.Drawing.Point(236, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 29);
            this.txtEmail.TabIndex = 9;

            // 
            // lblAlamat & txtAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblAlamat.Location = new System.Drawing.Point(516, 74);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(58, 20);
            this.lblAlamat.TabIndex = 10;
            this.lblAlamat.Text = "Alamat";

            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtAlamat.Location = new System.Drawing.Point(516, 96);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(346, 29);
            this.txtAlamat.TabIndex = 11;

            // 
            // lblUsername & txtUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(185, 88, 122);
            this.lblUsername.Location = new System.Drawing.Point(16, 134);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 20);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username Login";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtUsername.Location = new System.Drawing.Point(16, 156);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 29);
            this.txtUsername.TabIndex = 13;

            // 
            // lblPassword & txtPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(185, 88, 122);
            this.lblPassword.Location = new System.Drawing.Point(306, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 20);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password Login";

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtPassword.Location = new System.Drawing.Point(306, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 29);
            this.txtPassword.TabIndex = 15;

            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(16, 196);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(115, 34);
            this.btnTambah.TabIndex = 16;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;

            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(236, 175, 118);
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(141, 196);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(115, 34);
            this.btnUbah.TabIndex = 17;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;

            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(215, 95, 110);
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(266, 196);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 34);
            this.btnHapus.TabIndex = 18;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;

            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(238, 232, 235);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.btnReset.Location = new System.Drawing.Point(747, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 34);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;

            // 
            // dgvKaryawan
            // 
            this.dgvKaryawan.AllowUserToAddRows = false;
            this.dgvKaryawan.AllowUserToDeleteRows = false;
            this.dgvKaryawan.AllowUserToResizeRows = false;
            dgvAltRowStyle.BackColor = System.Drawing.Color.FromArgb(253, 246, 249);
            this.dgvKaryawan.AlternatingRowsDefaultCellStyle = dgvAltRowStyle;
            this.dgvKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKaryawan.BackgroundColor = System.Drawing.Color.White;
            this.dgvKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKaryawan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKaryawan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dgvKaryawan.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvKaryawan.ColumnHeadersHeight = 32;
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = System.Drawing.Color.White;
            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvCellStyle.ForeColor = System.Drawing.Color.FromArgb(65, 55, 60);
            dgvCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 224, 232);
            dgvCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(65, 55, 60);
            this.dgvKaryawan.DefaultCellStyle = dgvCellStyle;
            this.dgvKaryawan.EnableHeadersVisualStyles = false;
            this.dgvKaryawan.GridColor = System.Drawing.Color.FromArgb(242, 234, 238);
            this.dgvKaryawan.Location = new System.Drawing.Point(20, 332);
            this.dgvKaryawan.Name = "dgvKaryawan";
            this.dgvKaryawan.ReadOnly = true;
            this.dgvKaryawan.RowHeadersVisible = false;
            this.dgvKaryawan.RowTemplate.Height = 28;
            this.dgvKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKaryawan.Size = new System.Drawing.Size(880, 268);
            this.dgvKaryawan.TabIndex = 2;

            // 
            // FormAkunPekerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 247, 248);
            this.ClientSize = new System.Drawing.Size(920, 620);
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAkunPekerja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Bakery - Akun Pekerja";

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNik;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.Label lblDivisi;
        private System.Windows.Forms.ComboBox cmbDivisi;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvKaryawan;
    }
}