namespace Windforms_Toko_Roti.Views
{
    partial class Display_Owner
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnPengeluaran = new System.Windows.Forms.Button();
            this.btnAkunPekerja = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblBakery = new System.Windows.Forms.Label();
            this.lblCloud = new System.Windows.Forms.Label();
            this.lblLogoC = new System.Windows.Forms.Label();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();

            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblNamaRoti = new System.Windows.Forms.Label();
            this.txtNamaRoti = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.lblStok = new System.Windows.Forms.Label();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.lblEtalaseTitle = new System.Windows.Forms.Label();
            this.flpDisplay = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.pnlSidebar.Controls.Add(this.btnDisplay);
            this.pnlSidebar.Controls.Add(this.btnStok);
            this.pnlSidebar.Controls.Add(this.btnPenjualan);
            this.pnlSidebar.Controls.Add(this.btnPengeluaran);
            this.pnlSidebar.Controls.Add(this.btnAkunPekerja);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblMenu);
            this.pnlSidebar.Controls.Add(this.lblBakery);
            this.pnlSidebar.Controls.Add(this.lblCloud);
            this.pnlSidebar.Controls.Add(this.lblLogoC);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 726);
            this.pnlSidebar.TabIndex = 0;

            this.lblLogoC.BackColor = System.Drawing.Color.FromArgb(237, 236, 214);
            this.lblLogoC.Font = new System.Drawing.Font("High Tower Text", 26F, System.Drawing.FontStyle.Italic);
            this.lblLogoC.ForeColor = System.Drawing.Color.FromArgb(185, 88, 122);
            this.lblLogoC.Location = new System.Drawing.Point(24, 24);
            this.lblLogoC.Name = "lblLogoC";
            this.lblLogoC.Size = new System.Drawing.Size(55, 53);
            this.lblLogoC.Text = "C";
            this.lblLogoC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCloud.AutoSize = true;
            this.lblCloud.Font = new System.Drawing.Font("Lucida Calligraphy", 16.5F, System.Drawing.FontStyle.Bold);
            this.lblCloud.ForeColor = System.Drawing.Color.White;
            this.lblCloud.Location = new System.Drawing.Point(86, 22);
            this.lblCloud.Name = "lblCloud";
            this.lblCloud.Size = new System.Drawing.Size(105, 34);
            this.lblCloud.Text = "Cloud";

            this.lblBakery.AutoSize = true;
            this.lblBakery.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.lblBakery.ForeColor = System.Drawing.Color.FromArgb(253, 242, 246);
            this.lblBakery.Location = new System.Drawing.Point(89, 54);
            this.lblBakery.Name = "lblBakery";
            this.lblBakery.Size = new System.Drawing.Size(67, 25);
            this.lblBakery.Text = "Bakery";

            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(253, 232, 240);
            this.lblMenu.Location = new System.Drawing.Point(24, 114);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(52, 23);
            this.lblMenu.Text = "MENU";

            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(14, 146);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(202, 44);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;

            this.btnAkunPekerja.BackColor = System.Drawing.Color.Transparent;
            this.btnAkunPekerja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAkunPekerja.FlatAppearance.BorderSize = 0;
            this.btnAkunPekerja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnAkunPekerja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkunPekerja.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnAkunPekerja.ForeColor = System.Drawing.Color.White;
            this.btnAkunPekerja.Location = new System.Drawing.Point(14, 198);
            this.btnAkunPekerja.Name = "btnAkunPekerja";
            this.btnAkunPekerja.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAkunPekerja.Size = new System.Drawing.Size(202, 44);
            this.btnAkunPekerja.Text = "Akun Pekerja";
            this.btnAkunPekerja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAkunPekerja.UseVisualStyleBackColor = false;

            this.btnPengeluaran.BackColor = System.Drawing.Color.Transparent;
            this.btnPengeluaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPengeluaran.FlatAppearance.BorderSize = 0;
            this.btnPengeluaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengeluaran.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPengeluaran.ForeColor = System.Drawing.Color.White;
            this.btnPengeluaran.Location = new System.Drawing.Point(14, 250);
            this.btnPengeluaran.Name = "btnPengeluaran";
            this.btnPengeluaran.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnPengeluaran.Size = new System.Drawing.Size(202, 44);
            this.btnPengeluaran.Text = "Pengeluaran";
            this.btnPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengeluaran.UseVisualStyleBackColor = false;

            this.btnPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPenjualan.FlatAppearance.BorderSize = 0;
            this.btnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenjualan.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPenjualan.ForeColor = System.Drawing.Color.White;
            this.btnPenjualan.Location = new System.Drawing.Point(14, 302);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnPenjualan.Size = new System.Drawing.Size(202, 44);
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenjualan.UseVisualStyleBackColor = false;

            this.btnStok.BackColor = System.Drawing.Color.Transparent;
            this.btnStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.Location = new System.Drawing.Point(14, 354);
            this.btnStok.Name = "btnStok";
            this.btnStok.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnStok.Size = new System.Drawing.Size(202, 44);
            this.btnStok.Text = "Stok Bahan Baku";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.UseVisualStyleBackColor = false;

            // Active Menu: Display
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(199, 108, 140);
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(14, 406);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDisplay.Size = new System.Drawing.Size(202, 44);
            this.btnDisplay.Text = "Display";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplay.UseVisualStyleBackColor = false;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(237, 236, 214);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 74);

            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(210, 110, 145);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 12);
            this.lblHeaderTitle.Text = "Etalase & Display Produk Roti";

            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(120, 110, 115);
            this.lblHeaderSub.Location = new System.Drawing.Point(26, 42);
            this.lblHeaderSub.Text = "Kelola daftar varian roti, harga jual, deskripsi, dan ketersediaan stok display";

            // 
            // pnlFormCard
            // 
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.btnReset);
            this.pnlFormCard.Controls.Add(this.btnHapus);
            this.pnlFormCard.Controls.Add(this.btnUbah);
            this.pnlFormCard.Controls.Add(this.btnTambah);
            this.pnlFormCard.Controls.Add(this.txtDeskripsi);
            this.pnlFormCard.Controls.Add(this.lblDeskripsi);
            this.pnlFormCard.Controls.Add(this.numStok);
            this.pnlFormCard.Controls.Add(this.lblStok);
            this.pnlFormCard.Controls.Add(this.numHarga);
            this.pnlFormCard.Controls.Add(this.lblHarga);
            this.pnlFormCard.Controls.Add(this.txtNamaRoti);
            this.pnlFormCard.Controls.Add(this.lblNamaRoti);
            this.pnlFormCard.Location = new System.Drawing.Point(254, 90);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Size = new System.Drawing.Size(802, 185);

            this.lblNamaRoti.AutoSize = true;
            this.lblNamaRoti.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaRoti.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblNamaRoti.Location = new System.Drawing.Point(16, 12);
            this.lblNamaRoti.Text = "Nama Varian Roti";

            this.txtNamaRoti.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNamaRoti.Location = new System.Drawing.Point(16, 34);
            this.txtNamaRoti.Size = new System.Drawing.Size(270, 29);

            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblHarga.Location = new System.Drawing.Point(304, 12);
            this.lblHarga.Text = "Harga Jual (Rp)";

            this.numHarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numHarga.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numHarga.Location = new System.Drawing.Point(304, 34);
            this.numHarga.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numHarga.Size = new System.Drawing.Size(170, 29);

            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStok.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblStok.Location = new System.Drawing.Point(492, 12);
            this.lblStok.Text = "Stok Display (Pcs)";

            this.numStok.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numStok.Location = new System.Drawing.Point(492, 34);
            this.numStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numStok.Size = new System.Drawing.Size(130, 29);

            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.lblDeskripsi.Location = new System.Drawing.Point(16, 72);
            this.lblDeskripsi.Text = "Deskripsi Singkat Roti";

            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDeskripsi.Location = new System.Drawing.Point(16, 94);
            this.txtDeskripsi.Size = new System.Drawing.Size(768, 29);

            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(16, 136);
            this.btnTambah.Size = new System.Drawing.Size(115, 34);
            this.btnTambah.Text = "+ Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;

            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(236, 175, 118);
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(141, 136);
            this.btnUbah.Size = new System.Drawing.Size(115, 34);
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;

            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(215, 95, 110);
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(266, 136);
            this.btnHapus.Size = new System.Drawing.Size(115, 34);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;

            this.btnReset.BackColor = System.Drawing.Color.FromArgb(238, 232, 235);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(80, 70, 75);
            this.btnReset.Location = new System.Drawing.Point(669, 136);
            this.btnReset.Size = new System.Drawing.Size(115, 34);
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;

            // 
            // lblEtalaseTitle & flpDisplay (Wadah Kartu Produk Dinamis)
            // 
            this.lblEtalaseTitle.AutoSize = true;
            this.lblEtalaseTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEtalaseTitle.ForeColor = System.Drawing.Color.FromArgb(185, 88, 122);
            this.lblEtalaseTitle.Location = new System.Drawing.Point(254, 288);
            this.lblEtalaseTitle.Text = "Daftar Produk di Etalase (Klik kartu roti untuk mengedit atau menghapus)";

            this.flpDisplay.AutoScroll = true;
            this.flpDisplay.BackColor = System.Drawing.Color.Transparent;
            this.flpDisplay.Location = new System.Drawing.Point(250, 316);
            this.flpDisplay.Name = "flpDisplay";
            this.flpDisplay.Size = new System.Drawing.Size(810, 396);
            this.flpDisplay.TabIndex = 2;

            // 
            // Display_Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 247, 248);
            this.ClientSize = new System.Drawing.Size(1080, 726);
            this.Controls.Add(this.flpDisplay);
            this.Controls.Add(this.lblEtalaseTitle);
            this.Controls.Add(this.pnlFormCard);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Display_Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Bakery - Display Produk";

            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogoC;
        private System.Windows.Forms.Label lblCloud;
        private System.Windows.Forms.Label lblBakery;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAkunPekerja;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnDisplay;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;

        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblNamaRoti;
        private System.Windows.Forms.TextBox txtNamaRoti;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Label lblEtalaseTitle;
        private System.Windows.Forms.FlowLayoutPanel flpDisplay;
    }
}