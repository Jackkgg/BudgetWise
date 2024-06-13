namespace BudgetWise.Forms
{
    partial class AuthenticateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbQRCode = new PictureBox();
            txtOneTimePass = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            btnSubmitCode = new ReaLTaiizor.Controls.HopeButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbQRCode
            // 
            pbQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbQRCode.Location = new Point(73, 56);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(200, 200);
            pbQRCode.TabIndex = 0;
            pbQRCode.TabStop = false;
            // 
            // txtOneTimePass
            // 
            txtOneTimePass.BackColor = Color.White;
            txtOneTimePass.BaseColor = Color.FromArgb(44, 55, 66);
            txtOneTimePass.BorderColorA = Color.FromArgb(64, 158, 255);
            txtOneTimePass.BorderColorB = Color.FromArgb(220, 223, 230);
            txtOneTimePass.Font = new Font("Segoe UI", 12F);
            txtOneTimePass.ForeColor = Color.FromArgb(48, 49, 51);
            txtOneTimePass.Hint = "";
            txtOneTimePass.Location = new Point(23, 360);
            txtOneTimePass.MaxLength = 32767;
            txtOneTimePass.Multiline = false;
            txtOneTimePass.Name = "txtOneTimePass";
            txtOneTimePass.PasswordChar = '\0';
            txtOneTimePass.ScrollBars = ScrollBars.None;
            txtOneTimePass.SelectedText = "";
            txtOneTimePass.SelectionLength = 0;
            txtOneTimePass.SelectionStart = 0;
            txtOneTimePass.Size = new Size(300, 38);
            txtOneTimePass.TabIndex = 1;
            txtOneTimePass.TabStop = false;
            txtOneTimePass.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 336);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter One-Time-Pasword:";
            // 
            // btnSubmitCode
            // 
            btnSubmitCode.BorderColor = Color.FromArgb(220, 223, 230);
            btnSubmitCode.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSubmitCode.DangerColor = Color.FromArgb(245, 108, 108);
            btnSubmitCode.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSubmitCode.Font = new Font("Segoe UI", 12F);
            btnSubmitCode.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSubmitCode.InfoColor = Color.FromArgb(144, 147, 153);
            btnSubmitCode.Location = new Point(203, 404);
            btnSubmitCode.Name = "btnSubmitCode";
            btnSubmitCode.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSubmitCode.Size = new Size(120, 40);
            btnSubmitCode.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSubmitCode.TabIndex = 3;
            btnSubmitCode.Text = "Submit";
            btnSubmitCode.TextColor = Color.White;
            btnSubmitCode.WarningColor = Color.FromArgb(230, 162, 60);
            btnSubmitCode.Click += btnSubmitCode_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbQRCode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 330);
            panel1.TabIndex = 4;
            // 
            // AuthenticateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 474);
            Controls.Add(panel1);
            Controls.Add(btnSubmitCode);
            Controls.Add(label1);
            Controls.Add(txtOneTimePass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthenticateUser";
            Text = "AuthenticateUser";
            Load += AuthenticateUser_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbQRCode;
        private Label label1;
        public ReaLTaiizor.Controls.HopeTextBox txtOneTimePass;
        public ReaLTaiizor.Controls.HopeButton btnSubmitCode;
        private Panel panel1;
    }
}