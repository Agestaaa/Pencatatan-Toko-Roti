namespace Windforms_Toko_Roti.Views
{
    partial class FormDashboard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlCardPendapatan = new System.Windows.Forms.Panel();
            this.lblSubPendapatan = new System.Windows.Forms.Label();
            this.lblPendapatan = new System.Windows.Forms.Label();
            this.lblTitlePendapatan = new System.Windows.Forms.Label();
            this.pnlCardPengeluaran = new System.Windows.Forms.Panel();
            this.lblSubLaba = new System.Windows.Forms.Label();
            this.lblPengeluaran = new System.Windows.Forms.Label();
            this.lblTitlePengeluaran = new System.Windows.Forms.Label();
            this.pnlCardPekerja = new System.Windows.Forms.Panel();
            this.lblSubHadir = new System.Windows.Forms.Label();
            this.lblPekerja = new System.Windows.Forms.Label();
            this.lblTitlePekerja = new System.Windows.Forms.Label();
            this.pnlCardStok = new System.Windows.Forms.Panel();
            this.lblSubBahan = new System.Windows.Forms.Label();
            this.lblStokRoti = new System.Windows.Forms.Label();
            this.lblTitleStok = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tpPenjualan = new System.Windows.Forms.TabPage();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.tpPengeluaran = new System.Windows.Forms.TabPage();
            this.dgvPengeluaran = new System.Windows.Forms.DataGridView();
            this.tpStokBahan = new System.Windows.Forms.TabPage();
            this.dgvStokBahan = new System.Windows.Forms.DataGridView();
            this.tpDisplay = new System.Windows.Forms.TabPage();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tpProduksi = new System.Windows.Forms.TabPage();
            this.dgvProduksi = new System.Windows.Forms.DataGridView();
            this.tpKehadiran = new System.Windows.Forms.TabPage();
            this.dgvKehadiran = new System.Windows.Forms.DataGridView();
            this.pnlCardPendapatan.SuspendLayout();
            this.pnlCardPengeluaran.SuspendLayout();
            this.pnlCardPekerja.SuspendLayout();
            this.pnlCardStok.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tpPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.tpPengeluaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaran)).BeginInit();
            this.tpStokBahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBahan)).BeginInit();
            this.tpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tpProduksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduksi)).BeginInit();
            this.tpKehadiran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKehadiran)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 35);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Dashboard Cloud Bakery";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(145)))), ((int)(((byte)(171)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(786, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 36);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlCardPendapatan
            // 
            this.pnlCardPendapatan.BackColor = System.Drawing.Color.White;
            this.pnlCardPendapatan.Controls.Add(this.lblSubPendapatan);
            this.pnlCardPendapatan.Controls.Add(this.lblPendapatan);
            this.pnlCardPendapatan.Controls.Add(this.lblTitlePendapatan);
            this.pnlCardPendapatan.Location = new System.Drawing.Point(24, 78);
            this.pnlCardPendapatan.Name = "pnlCardPendapatan";
            this.pnlCardPendapatan.Size = new System.Drawing.Size(210, 104);
            this.pnlCardPendapatan.TabIndex = 4;
            // 
            // lblSubPendapatan
            // 
            this.lblSubPendapatan.AutoSize = true;
            this.lblSubPendapatan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubPendapatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.lblSubPendapatan.Location = new System.Drawing.Point(14, 74);
            this.lblSubPendapatan.Name = "lblSubPendapatan";
            this.lblSubPendapatan.Size = new System.Drawing.Size(78, 20);
            this.lblSubPendapatan.TabIndex = 0;
            this.lblSubPendapatan.Text = "0 transaksi";
            // 
            // lblPendapatan
            // 
            this.lblPendapatan.AutoSize = true;
            this.lblPendapatan.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblPendapatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.lblPendapatan.Location = new System.Drawing.Point(14, 42);
            this.lblPendapatan.Name = "lblPendapatan";
            this.lblPendapatan.Size = new System.Drawing.Size(62, 31);
            this.lblPendapatan.TabIndex = 1;
            this.lblPendapatan.Text = "Rp 0";
            // 
            // lblTitlePendapatan
            // 
            this.lblTitlePendapatan.AutoSize = true;
            this.lblTitlePendapatan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitlePendapatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.lblTitlePendapatan.Location = new System.Drawing.Point(14, 16);
            this.lblTitlePendapatan.Name = "lblTitlePendapatan";
            this.lblTitlePendapatan.Size = new System.Drawing.Size(113, 20);
            this.lblTitlePendapatan.TabIndex = 2;
            this.lblTitlePendapatan.Text = "Total Penjualan";
            // 
            // pnlCardPengeluaran
            // 
            this.pnlCardPengeluaran.BackColor = System.Drawing.Color.White;
            this.pnlCardPengeluaran.Controls.Add(this.lblSubLaba);
            this.pnlCardPengeluaran.Controls.Add(this.lblPengeluaran);
            this.pnlCardPengeluaran.Controls.Add(this.lblTitlePengeluaran);
            this.pnlCardPengeluaran.Location = new System.Drawing.Point(248, 78);
            this.pnlCardPengeluaran.Name = "pnlCardPengeluaran";
            this.pnlCardPengeluaran.Size = new System.Drawing.Size(210, 104);
            this.pnlCardPengeluaran.TabIndex = 3;
            // 
            // lblSubLaba
            // 
            this.lblSubLaba.AutoSize = true;
            this.lblSubLaba.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubLaba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.lblSubLaba.Location = new System.Drawing.Point(14, 74);
            this.lblSubLaba.Name = "lblSubLaba";
            this.lblSubLaba.Size = new System.Drawing.Size(78, 20);
            this.lblSubLaba.TabIndex = 0;
            this.lblSubLaba.Text = "Laba: Rp 0";
            // 
            // lblPengeluaran
            // 
            this.lblPengeluaran.AutoSize = true;
            this.lblPengeluaran.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblPengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))));
            this.lblPengeluaran.Location = new System.Drawing.Point(14, 42);
            this.lblPengeluaran.Name = "lblPengeluaran";
            this.lblPengeluaran.Size = new System.Drawing.Size(62, 31);
            this.lblPengeluaran.TabIndex = 1;
            this.lblPengeluaran.Text = "Rp 0";
            // 
            // lblTitlePengeluaran
            // 
            this.lblTitlePengeluaran.AutoSize = true;
            this.lblTitlePengeluaran.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitlePengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.lblTitlePengeluaran.Location = new System.Drawing.Point(14, 16);
            this.lblTitlePengeluaran.Name = "lblTitlePengeluaran";
            this.lblTitlePengeluaran.Size = new System.Drawing.Size(132, 20);
            this.lblTitlePengeluaran.TabIndex = 2;
            this.lblTitlePengeluaran.Text = "Total Pengeluaran";
            // 
            // pnlCardPekerja
            // 
            this.pnlCardPekerja.BackColor = System.Drawing.Color.White;
            this.pnlCardPekerja.Controls.Add(this.lblSubHadir);
            this.pnlCardPekerja.Controls.Add(this.lblPekerja);
            this.pnlCardPekerja.Controls.Add(this.lblTitlePekerja);
            this.pnlCardPekerja.Location = new System.Drawing.Point(472, 78);
            this.pnlCardPekerja.Name = "pnlCardPekerja";
            this.pnlCardPekerja.Size = new System.Drawing.Size(210, 104);
            this.pnlCardPekerja.TabIndex = 2;
            // 
            // lblSubHadir
            // 
            this.lblSubHadir.AutoSize = true;
            this.lblSubHadir.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubHadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.lblSubHadir.Location = new System.Drawing.Point(14, 74);
            this.lblSubHadir.Name = "lblSubHadir";
            this.lblSubHadir.Size = new System.Drawing.Size(104, 20);
            this.lblSubHadir.TabIndex = 0;
            this.lblSubHadir.Text = "Hadir: 0 orang";
            // 
            // lblPekerja
            // 
            this.lblPekerja.AutoSize = true;
            this.lblPekerja.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblPekerja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(104)))));
            this.lblPekerja.Location = new System.Drawing.Point(14, 42);
            this.lblPekerja.Name = "lblPekerja";
            this.lblPekerja.Size = new System.Drawing.Size(27, 31);
            this.lblPekerja.TabIndex = 1;
            this.lblPekerja.Text = "0";
            // 
            // lblTitlePekerja
            // 
            this.lblTitlePekerja.AutoSize = true;
            this.lblTitlePekerja.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitlePekerja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.lblTitlePekerja.Location = new System.Drawing.Point(14, 16);
            this.lblTitlePekerja.Name = "lblTitlePekerja";
            this.lblTitlePekerja.Size = new System.Drawing.Size(96, 20);
            this.lblTitlePekerja.TabIndex = 2;
            this.lblTitlePekerja.Text = "Total Pekerja";
            // 
            // pnlCardStok
            // 
            this.pnlCardStok.BackColor = System.Drawing.Color.White;
            this.pnlCardStok.Controls.Add(this.lblSubBahan);
            this.pnlCardStok.Controls.Add(this.lblStokRoti);
            this.pnlCardStok.Controls.Add(this.lblTitleStok);
            this.pnlCardStok.Location = new System.Drawing.Point(696, 78);
            this.pnlCardStok.Name = "pnlCardStok";
            this.pnlCardStok.Size = new System.Drawing.Size(210, 104);
            this.pnlCardStok.TabIndex = 1;
            this.pnlCardStok.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardStok_Paint);
            // 
            // lblSubBahan
            // 
            this.lblSubBahan.AutoSize = true;
            this.lblSubBahan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubBahan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.lblSubBahan.Location = new System.Drawing.Point(14, 74);
            this.lblSubBahan.Name = "lblSubBahan";
            this.lblSubBahan.Size = new System.Drawing.Size(155, 20);
            this.lblSubBahan.TabIndex = 0;
            this.lblSubBahan.Text = "Bahan menipis: 0 item";
            // 
            // lblStokRoti
            // 
            this.lblStokRoti.AutoSize = true;
            this.lblStokRoti.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblStokRoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(86)))), ((int)(((byte)(142)))));
            this.lblStokRoti.Location = new System.Drawing.Point(14, 42);
            this.lblStokRoti.Name = "lblStokRoti";
            this.lblStokRoti.Size = new System.Drawing.Size(27, 31);
            this.lblStokRoti.TabIndex = 1;
            this.lblStokRoti.Text = "0";
            // 
            // lblTitleStok
            // 
            this.lblTitleStok.AutoSize = true;
            this.lblTitleStok.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.lblTitleStok.Location = new System.Drawing.Point(14, 16);
            this.lblTitleStok.Name = "lblTitleStok";
            this.lblTitleStok.Size = new System.Drawing.Size(124, 20);
            this.lblTitleStok.TabIndex = 2;
            this.lblTitleStok.Text = "Stok Roti Display";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tpPenjualan);
            this.tabData.Controls.Add(this.tpPengeluaran);
            this.tabData.Controls.Add(this.tpStokBahan);
            this.tabData.Controls.Add(this.tpDisplay);
            this.tabData.Controls.Add(this.tpProduksi);
            this.tabData.Controls.Add(this.tpKehadiran);
            this.tabData.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabData.Location = new System.Drawing.Point(24, 198);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(882, 430);
            this.tabData.TabIndex = 0;
            // 
            // tpPenjualan
            // 
            this.tpPenjualan.BackColor = System.Drawing.Color.White;
            this.tpPenjualan.Controls.Add(this.dgvPenjualan);
            this.tpPenjualan.Location = new System.Drawing.Point(4, 30);
            this.tpPenjualan.Name = "tpPenjualan";
            this.tpPenjualan.Padding = new System.Windows.Forms.Padding(8);
            this.tpPenjualan.Size = new System.Drawing.Size(874, 396);
            this.tpPenjualan.TabIndex = 0;
            this.tpPenjualan.Text = "Penjualan";
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeight = 29;
            this.dgvPenjualan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPenjualan.Location = new System.Drawing.Point(8, 8);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.RowHeadersWidth = 51;
            this.dgvPenjualan.Size = new System.Drawing.Size(858, 380);
            this.dgvPenjualan.TabIndex = 0;
            // 
            // tpPengeluaran
            // 
            this.tpPengeluaran.BackColor = System.Drawing.Color.White;
            this.tpPengeluaran.Controls.Add(this.dgvPengeluaran);
            this.tpPengeluaran.Location = new System.Drawing.Point(4, 30);
            this.tpPengeluaran.Name = "tpPengeluaran";
            this.tpPengeluaran.Padding = new System.Windows.Forms.Padding(8);
            this.tpPengeluaran.Size = new System.Drawing.Size(874, 396);
            this.tpPengeluaran.TabIndex = 1;
            this.tpPengeluaran.Text = "Pengeluaran";
            // 
            // dgvPengeluaran
            // 
            this.dgvPengeluaran.ColumnHeadersHeight = 29;
            this.dgvPengeluaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPengeluaran.Location = new System.Drawing.Point(8, 8);
            this.dgvPengeluaran.Name = "dgvPengeluaran";
            this.dgvPengeluaran.RowHeadersWidth = 51;
            this.dgvPengeluaran.Size = new System.Drawing.Size(858, 380);
            this.dgvPengeluaran.TabIndex = 0;
            // 
            // tpStokBahan
            // 
            this.tpStokBahan.BackColor = System.Drawing.Color.White;
            this.tpStokBahan.Controls.Add(this.dgvStokBahan);
            this.tpStokBahan.Location = new System.Drawing.Point(4, 30);
            this.tpStokBahan.Name = "tpStokBahan";
            this.tpStokBahan.Padding = new System.Windows.Forms.Padding(8);
            this.tpStokBahan.Size = new System.Drawing.Size(874, 396);
            this.tpStokBahan.TabIndex = 2;
            this.tpStokBahan.Text = "Stok Bahan Baku";
            // 
            // dgvStokBahan
            // 
            this.dgvStokBahan.ColumnHeadersHeight = 29;
            this.dgvStokBahan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokBahan.Location = new System.Drawing.Point(8, 8);
            this.dgvStokBahan.Name = "dgvStokBahan";
            this.dgvStokBahan.RowHeadersWidth = 51;
            this.dgvStokBahan.Size = new System.Drawing.Size(858, 380);
            this.dgvStokBahan.TabIndex = 0;
            // 
            // tpDisplay
            // 
            this.tpDisplay.BackColor = System.Drawing.Color.White;
            this.tpDisplay.Controls.Add(this.dgvDisplay);
            this.tpDisplay.Location = new System.Drawing.Point(4, 30);
            this.tpDisplay.Name = "tpDisplay";
            this.tpDisplay.Padding = new System.Windows.Forms.Padding(8);
            this.tpDisplay.Size = new System.Drawing.Size(874, 396);
            this.tpDisplay.TabIndex = 3;
            this.tpDisplay.Text = "Display Roti";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeight = 29;
            this.dgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplay.Location = new System.Drawing.Point(8, 8);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.Size = new System.Drawing.Size(858, 380);
            this.dgvDisplay.TabIndex = 0;
            // 
            // tpProduksi
            // 
            this.tpProduksi.BackColor = System.Drawing.Color.White;
            this.tpProduksi.Controls.Add(this.dgvProduksi);
            this.tpProduksi.Location = new System.Drawing.Point(4, 30);
            this.tpProduksi.Name = "tpProduksi";
            this.tpProduksi.Padding = new System.Windows.Forms.Padding(8);
            this.tpProduksi.Size = new System.Drawing.Size(874, 396);
            this.tpProduksi.TabIndex = 4;
            this.tpProduksi.Text = "Riwayat Produksi";
            // 
            // dgvProduksi
            // 
            this.dgvProduksi.ColumnHeadersHeight = 29;
            this.dgvProduksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduksi.Location = new System.Drawing.Point(8, 8);
            this.dgvProduksi.Name = "dgvProduksi";
            this.dgvProduksi.RowHeadersWidth = 51;
            this.dgvProduksi.Size = new System.Drawing.Size(858, 380);
            this.dgvProduksi.TabIndex = 0;
            // 
            // tpKehadiran
            // 
            this.tpKehadiran.BackColor = System.Drawing.Color.White;
            this.tpKehadiran.Controls.Add(this.dgvKehadiran);
            this.tpKehadiran.Location = new System.Drawing.Point(4, 30);
            this.tpKehadiran.Name = "tpKehadiran";
            this.tpKehadiran.Padding = new System.Windows.Forms.Padding(8);
            this.tpKehadiran.Size = new System.Drawing.Size(874, 396);
            this.tpKehadiran.TabIndex = 5;
            this.tpKehadiran.Text = "Kehadiran Pekerja";
            // 
            // dgvKehadiran
            // 
            this.dgvKehadiran.ColumnHeadersHeight = 29;
            this.dgvKehadiran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKehadiran.Location = new System.Drawing.Point(8, 8);
            this.dgvKehadiran.Name = "dgvKehadiran";
            this.dgvKehadiran.RowHeadersWidth = 51;
            this.dgvKehadiran.Size = new System.Drawing.Size(858, 380);
            this.dgvKehadiran.TabIndex = 0;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(930, 650);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.pnlCardStok);
            this.Controls.Add(this.pnlCardPekerja);
            this.Controls.Add(this.pnlCardPengeluaran);
            this.Controls.Add(this.pnlCardPendapatan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Dashboard Owner";
            this.pnlCardPendapatan.ResumeLayout(false);
            this.pnlCardPendapatan.PerformLayout();
            this.pnlCardPengeluaran.ResumeLayout(false);
            this.pnlCardPengeluaran.PerformLayout();
            this.pnlCardPekerja.ResumeLayout(false);
            this.pnlCardPekerja.PerformLayout();
            this.pnlCardStok.ResumeLayout(false);
            this.pnlCardStok.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tpPenjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.tpPengeluaran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaran)).EndInit();
            this.tpStokBahan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBahan)).EndInit();
            this.tpDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tpProduksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduksi)).EndInit();
            this.tpKehadiran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKehadiran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlCardPendapatan;
        private System.Windows.Forms.Label lblTitlePendapatan;
        private System.Windows.Forms.Label lblPendapatan;
        private System.Windows.Forms.Label lblSubPendapatan;

        private System.Windows.Forms.Panel pnlCardPengeluaran;
        private System.Windows.Forms.Label lblTitlePengeluaran;
        private System.Windows.Forms.Label lblPengeluaran;
        private System.Windows.Forms.Label lblSubLaba;

        private System.Windows.Forms.Panel pnlCardPekerja;
        private System.Windows.Forms.Label lblTitlePekerja;
        private System.Windows.Forms.Label lblPekerja;
        private System.Windows.Forms.Label lblSubHadir;

        private System.Windows.Forms.Panel pnlCardStok;
        private System.Windows.Forms.Label lblTitleStok;
        private System.Windows.Forms.Label lblStokRoti;
        private System.Windows.Forms.Label lblSubBahan;

        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tpPenjualan;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.TabPage tpPengeluaran;
        private System.Windows.Forms.DataGridView dgvPengeluaran;
        private System.Windows.Forms.TabPage tpStokBahan;
        private System.Windows.Forms.DataGridView dgvStokBahan;
        private System.Windows.Forms.TabPage tpDisplay;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TabPage tpProduksi;
        private System.Windows.Forms.DataGridView dgvProduksi;
        private System.Windows.Forms.TabPage tpKehadiran;
        private System.Windows.Forms.DataGridView dgvKehadiran;
    }
}