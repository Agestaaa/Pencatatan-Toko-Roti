namespace Windforms_Toko_Roti.Views
{
    partial class FormUtamaOwner
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
            this.btnStokBahan = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnPengeluaran = new System.Windows.Forms.Button();
            this.btnAkunPekerja = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblLogoIcon = new System.Windows.Forms.Label();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblProfilNama = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();

            this.pnlKonten = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.pnlSidebar.Controls.Add(this.btnDisplay);
            this.pnlSidebar.Controls.Add(this.btnStokBahan);
            this.pnlSidebar.Controls.Add(this.btnPenjualan);
            this.pnlSidebar.Controls.Add(this.btnPengeluaran);
            this.pnlSidebar.Controls.Add(this.btnAkunPekerja);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblMenuTitle);
            this.pnlSidebar.Controls.Add(this.lblBrandSub);
            this.pnlSidebar.Controls.Add(this.lblBrandTitle);
            this.pnlSidebar.Controls.Add(this.lblLogoIcon);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 720);
            this.pnlSidebar.TabIndex = 0;

            this.lblLogoIcon.BackColor = System.Drawing.Color.FromArgb(248, 244, 236);
            this.lblLogoIcon.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(190, 95, 130);
            this.lblLogoIcon.Location = new System.Drawing.Point(24, 24);
            this.lblLogoIcon.Size = new System.Drawing.Size(54, 54);
            this.lblLogoIcon.Text = "C";
            this.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(86, 22);
            this.lblBrandTitle.Text = "Cloud";

            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(253, 242, 246);
            this.lblBrandSub.Location = new System.Drawing.Point(89, 53);
            this.lblBrandSub.Text = "Bakery";

            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(253, 232, 240);
            this.lblMenuTitle.Location = new System.Drawing.Point(24, 112);
            this.lblMenuTitle.Text = "MENU UTAMA";

            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(14, 144);
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(202, 44);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;

            this.btnAkunPekerja.BackColor = System.Drawing.Color.Transparent;
            this.btnAkunPekerja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAkunPekerja.FlatAppearance.BorderSize = 0;
            this.btnAkunPekerja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnAkunPekerja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkunPekerja.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAkunPekerja.ForeColor = System.Drawing.Color.White;
            this.btnAkunPekerja.Location = new System.Drawing.Point(14, 196);
            this.btnAkunPekerja.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAkunPekerja.Size = new System.Drawing.Size(202, 44);
            this.btnAkunPekerja.Text = "Akun Pekerja";
            this.btnAkunPekerja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAkunPekerja.UseVisualStyleBackColor = false;

            this.btnPengeluaran.BackColor = System.Drawing.Color.Transparent;
            this.btnPengeluaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPengeluaran.FlatAppearance.BorderSize = 0;
            this.btnPengeluaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengeluaran.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPengeluaran.ForeColor = System.Drawing.Color.White;
            this.btnPengeluaran.Location = new System.Drawing.Point(14, 248);
            this.btnPengeluaran.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnPengeluaran.Size = new System.Drawing.Size(202, 44);
            this.btnPengeluaran.Text = "Pengeluaran";
            this.btnPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengeluaran.UseVisualStyleBackColor = false;

            this.btnPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPenjualan.FlatAppearance.BorderSize = 0;
            this.btnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenjualan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPenjualan.ForeColor = System.Drawing.Color.White;
            this.btnPenjualan.Location = new System.Drawing.Point(14, 300);
            this.btnPenjualan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnPenjualan.Size = new System.Drawing.Size(202, 44);
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenjualan.UseVisualStyleBackColor = false;

            this.btnStokBahan.BackColor = System.Drawing.Color.Transparent;
            this.btnStokBahan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokBahan.FlatAppearance.BorderSize = 0;
            this.btnStokBahan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnStokBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokBahan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnStokBahan.ForeColor = System.Drawing.Color.White;
            this.btnStokBahan.Location = new System.Drawing.Point(14, 352);
            this.btnStokBahan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnStokBahan.Size = new System.Drawing.Size(202, 44);
            this.btnStokBahan.Text = "Stok Bahan Baku";
            this.btnStokBahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokBahan.UseVisualStyleBackColor = false;

            this.btnDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(212, 126, 155);
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(14, 404);
            this.btnDisplay.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDisplay.Size = new System.Drawing.Size(202, 44);
            this.btnDisplay.Text = "Display Roti";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplay.UseVisualStyleBackColor = false;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(245, 240, 235);
            this.pnlHeader.Controls.Add(this.lblGreeting);
            this.pnlHeader.Controls.Add(this.lblProfilNama);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Size = new System.Drawing.Size(930, 70);

            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(185, 88, 122);
            this.lblGreeting.Location = new System.Drawing.Point(24, 22);
            this.lblGreeting.Text = "Selamat Datang, Owner!";

            this.lblProfilNama.AutoSize = true;
            this.lblProfilNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProfilNama.ForeColor = System.Drawing.Color.FromArgb(75, 65, 70);
            this.lblProfilNama.Location = new System.Drawing.Point(710, 25);
            this.lblProfilNama.Text = "Profil Owner";

            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(199, 108, 140);
            this.btnLogout.Location = new System.Drawing.Point(812, 18);
            this.btnLogout.Size = new System.Drawing.Size(94, 34);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;

            // 
            // pnlKonten (Wadah tempat Form Fitur muncul)
            // 
            this.pnlKonten.BackColor = System.Drawing.Color.FromArgb(250, 247, 248);
            this.pnlKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKonten.Location = new System.Drawing.Point(230, 70);
            this.pnlKonten.Name = "pnlKonten";
            this.pnlKonten.Size = new System.Drawing.Size(930, 650);

            // 
            // FormUtamaOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 720);
            this.Controls.Add(this.pnlKonten);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUtamaOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Bakery - Sistem Manajemen Toko Roti";

            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAkunPekerja;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnStokBahan;
        private System.Windows.Forms.Button btnDisplay;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblProfilNama;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlKonten;
    }
}