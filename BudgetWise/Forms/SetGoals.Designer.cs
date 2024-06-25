namespace BudgetWise.Forms
{
    partial class SetGoals
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFuture = new ReaLTaiizor.Controls.HopeTextBox();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            txtLuxuries = new ReaLTaiizor.Controls.HopeTextBox();
            txtNecessities = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 13;
            label3.Text = "Future You";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Luxuries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 11;
            label1.Text = "Necessities";
            // 
            // txtFuture
            // 
            txtFuture.BackColor = Color.White;
            txtFuture.BaseColor = Color.FromArgb(44, 55, 66);
            txtFuture.BorderColorA = Color.FromArgb(64, 158, 255);
            txtFuture.BorderColorB = Color.FromArgb(220, 223, 230);
            txtFuture.Font = new Font("Segoe UI", 12F);
            txtFuture.ForeColor = Color.FromArgb(48, 49, 51);
            txtFuture.Hint = "";
            txtFuture.Location = new Point(12, 174);
            txtFuture.MaxLength = 32767;
            txtFuture.Multiline = false;
            txtFuture.Name = "txtFuture";
            txtFuture.PasswordChar = '\0';
            txtFuture.ScrollBars = ScrollBars.None;
            txtFuture.SelectedText = "";
            txtFuture.SelectionLength = 0;
            txtFuture.SelectionStart = 0;
            txtFuture.Size = new Size(542, 38);
            txtFuture.TabIndex = 10;
            txtFuture.TabStop = false;
            txtFuture.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(434, 218);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSave.Size = new Size(120, 40);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += hopeButton1_Click;
            // 
            // txtLuxuries
            // 
            txtLuxuries.BackColor = Color.White;
            txtLuxuries.BaseColor = Color.FromArgb(44, 55, 66);
            txtLuxuries.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLuxuries.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLuxuries.Font = new Font("Segoe UI", 12F);
            txtLuxuries.ForeColor = Color.FromArgb(48, 49, 51);
            txtLuxuries.Hint = "";
            txtLuxuries.Location = new Point(12, 106);
            txtLuxuries.MaxLength = 32767;
            txtLuxuries.Multiline = false;
            txtLuxuries.Name = "txtLuxuries";
            txtLuxuries.PasswordChar = '\0';
            txtLuxuries.ScrollBars = ScrollBars.None;
            txtLuxuries.SelectedText = "";
            txtLuxuries.SelectionLength = 0;
            txtLuxuries.SelectionStart = 0;
            txtLuxuries.Size = new Size(542, 38);
            txtLuxuries.TabIndex = 8;
            txtLuxuries.TabStop = false;
            txtLuxuries.UseSystemPasswordChar = false;
            // 
            // txtNecessities
            // 
            txtNecessities.BackColor = Color.White;
            txtNecessities.BaseColor = Color.FromArgb(44, 55, 66);
            txtNecessities.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNecessities.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNecessities.Font = new Font("Segoe UI", 12F);
            txtNecessities.ForeColor = Color.FromArgb(48, 49, 51);
            txtNecessities.Hint = "";
            txtNecessities.Location = new Point(12, 40);
            txtNecessities.MaxLength = 32767;
            txtNecessities.Multiline = false;
            txtNecessities.Name = "txtNecessities";
            txtNecessities.PasswordChar = '\0';
            txtNecessities.ScrollBars = ScrollBars.None;
            txtNecessities.SelectedText = "";
            txtNecessities.SelectionLength = 0;
            txtNecessities.SelectionStart = 0;
            txtNecessities.Size = new Size(542, 38);
            txtNecessities.TabIndex = 7;
            txtNecessities.TabStop = false;
            txtNecessities.UseSystemPasswordChar = false;
            // 
            // SetGoals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 270);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFuture);
            Controls.Add(btnSave);
            Controls.Add(txtLuxuries);
            Controls.Add(txtNecessities);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetGoals";
            Text = "SetGoals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox txtFuture;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private ReaLTaiizor.Controls.HopeTextBox txtLuxuries;
        private ReaLTaiizor.Controls.HopeTextBox txtNecessities;
    }
}