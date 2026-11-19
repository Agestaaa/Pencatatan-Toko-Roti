namespace Windforms_Toko_Roti.Views
{
    partial class Login
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLogoCircle = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblFooterNote = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlLeft (Branding Panel)
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.pnlLeft.Controls.Add(this.lblTagline);
            this.pnlLeft.Controls.Add(this.lblBrandSub);
            this.pnlLeft.Controls.Add(this.lblBrandName);
            this.pnlLeft.Controls.Add(this.lblLogoCircle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(360, 520);
            this.pnlLeft.TabIndex = 0;

            // 
            // lblLogoCircle
            // 
            this.lblLogoCircle.BackColor = System.Drawing.Color.FromArgb(248, 244, 236);
            this.lblLogoCircle.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblLogoCircle.ForeColor = System.Drawing.Color.FromArgb(190, 95, 130);
            this.lblLogoCircle.Location = new System.Drawing.Point(135, 130);
            this.lblLogoCircle.Name = "lblLogoCircle";
            this.lblLogoCircle.Size = new System.Drawing.Size(90, 90);
            this.lblLogoCircle.TabIndex = 0;
            this.lblLogoCircle.Text = "C";
            this.lblLogoCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblBrandName
            // 
            this.lblBrandName.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(30, 238);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(300, 48);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "Cloud Bakery";
            this.lblBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblBrandSub
            // 
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(253, 238, 243);
            this.lblBrandSub.Location = new System.Drawing.Point(30, 290);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(300, 26);
            this.lblBrandSub.TabIndex = 2;
            this.lblBrandSub.Text = "Sistem Informasi Manajemen Toko Roti";
            this.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTagline
            // 
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(253, 244, 247);
            this.lblTagline.Location = new System.Drawing.Point(40, 326);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(280, 44);
            this.lblTagline.TabIndex = 3;
            this.lblTagline.Text = "Kelola stok bahan baku, produksi display, transaksi kasir, dan presensi karyawan.";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // pnlRight (Login Form Panel)
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(250, 247, 248);
            this.pnlRight.Controls.Add(this.lblFooterNote);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.chkShowPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.lblInstruction);
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(360, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(460, 520);
            this.pnlRight.TabIndex = 1;

            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 225, 232);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(185, 88, 122);
            this.btnClose.Location = new System.Drawing.Point(412, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;

            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(65, 55, 60);
            this.lblWelcome.Location = new System.Drawing.Point(56, 75);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(218, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Masuk Akun";

            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(130, 120, 125);
            this.lblInstruction.Location = new System.Drawing.Point(59, 122);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(288, 21);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Silakan masukkan username dan password Anda";

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(90, 80, 85);
            this.lblUsername.Location = new System.Drawing.Point(60, 170);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtUsername.Location = new System.Drawing.Point(60, 196);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(340, 32);
            this.txtUsername.TabIndex = 3;

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(90, 80, 85);
            this.lblPassword.Location = new System.Drawing.Point(60, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 21);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";

            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtPassword.Location = new System.Drawing.Point(60, 272);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 32);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(115, 105, 110);
            this.chkShowPassword.Location = new System.Drawing.Point(60, 314);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(166, 24);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Tampilkan password";
            this.chkShowPassword.UseVisualStyleBackColor = true;

            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(225, 145, 171);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(204, 116, 146);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 360);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(340, 44);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "MASUK";
            this.btnLogin.UseVisualStyleBackColor = false;

            // 
            // lblFooterNote
            // 
            this.lblFooterNote.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblFooterNote.ForeColor = System.Drawing.Color.FromArgb(155, 145, 150);
            this.lblFooterNote.Location = new System.Drawing.Point(60, 424);
            this.lblFooterNote.Name = "lblFooterNote";
            this.lblFooterNote.Size = new System.Drawing.Size(340, 36);
            this.lblFooterNote.TabIndex = 8;
            this.lblFooterNote.Text = "Presensi pekerja akan tercatat otomatis saat berhasil login.";
            this.lblFooterNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Bakery - Login";

            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLogoCircle;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblFooterNote;
    }
}