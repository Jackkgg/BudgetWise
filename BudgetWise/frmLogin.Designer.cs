namespace BudgetWise
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblSignUp = new ReaLTaiizor.Controls.LinkLabelEdit();
            btnLogin = new ReaLTaiizor.Controls.HopeRoundButton();
            lblForgotPassword = new ReaLTaiizor.Controls.LinkLabelEdit();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtUsername = new ReaLTaiizor.Controls.HopeTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.VibrantImage;
            pictureBox1.Location = new Point(336, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(664, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSignUp);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblForgotPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 600);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 307);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // lblSignUp
            // 
            lblSignUp.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.Transparent;
            lblSignUp.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lblSignUp.LinkColor = Color.FromArgb(32, 34, 37);
            lblSignUp.Location = new Point(123, 490);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(89, 13);
            lblSignUp.TabIndex = 4;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "Or Sign Up Here";
            lblSignUp.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            lblSignUp.LinkClicked += lblSignUp_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(12, 421);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnLogin.Size = new Size(310, 40);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgotPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            lblForgotPassword.LinkColor = Color.FromArgb(32, 34, 37);
            lblForgotPassword.Location = new Point(12, 382);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(130, 20);
            lblForgotPassword.TabIndex = 3;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BaseColor = Color.FromArgb(44, 55, 66);
            txtPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtPassword.Hint = "";
            txtPassword.Location = new Point(12, 327);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(310, 38);
            txtPassword.TabIndex = 1;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BaseColor = Color.FromArgb(44, 55, 66);
            txtUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            txtUsername.BorderColorB = Color.FromArgb(220, 223, 230);
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.FromArgb(48, 49, 51);
            txtUsername.Hint = "";
            txtUsername.Location = new Point(12, 258);
            txtUsername.MaxLength = 32767;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(310, 38);
            txtUsername.TabIndex = 0;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BudgetWise";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private ReaLTaiizor.Controls.LinkLabelEdit lblForgotPassword;
        private ReaLTaiizor.Controls.LinkLabelEdit lblSignUp;
        private ReaLTaiizor.Controls.HopeRoundButton btnLogin;
        private Label label2;
        private Label label1;
    }
}
