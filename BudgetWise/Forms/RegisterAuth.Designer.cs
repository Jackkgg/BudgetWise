namespace BudgetWise.Forms
{
    partial class RegisterAuth
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
            btnDone = new ReaLTaiizor.Controls.HopeButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            SuspendLayout();
            // 
            // pbQRCode
            // 
            pbQRCode.Location = new Point(75, 75);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(200, 200);
            pbQRCode.TabIndex = 1;
            pbQRCode.TabStop = false;
            // 
            // btnDone
            // 
            btnDone.BorderColor = Color.FromArgb(220, 223, 230);
            btnDone.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDone.DangerColor = Color.FromArgb(245, 108, 108);
            btnDone.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDone.Font = new Font("Segoe UI", 12F);
            btnDone.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDone.InfoColor = Color.FromArgb(144, 147, 153);
            btnDone.Location = new Point(113, 298);
            btnDone.Name = "btnDone";
            btnDone.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnDone.Size = new Size(120, 40);
            btnDone.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDone.TabIndex = 2;
            btnDone.Text = "Done";
            btnDone.TextColor = Color.White;
            btnDone.WarningColor = Color.FromArgb(230, 162, 60);
            btnDone.Click += btnDone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 55);
            label1.Name = "label1";
            label1.Size = new Size(310, 17);
            label1.TabIndex = 7;
            label1.Text = "Please scan with your Google Authenticator app...";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 350);
            Controls.Add(label1);
            Controls.Add(btnDone);
            Controls.Add(pbQRCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterAuth";
            Text = "RegisterAuth";
            Load += RegisterAuth_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbQRCode;
        private ReaLTaiizor.Controls.HopeButton btnDone;
        private Label label1;
    }
}