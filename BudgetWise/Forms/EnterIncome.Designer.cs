namespace BudgetWise.Forms
{
    partial class EnterIncome
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
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            txtAmount = new ReaLTaiizor.Controls.HopeTextBox();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            txtType = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.FromArgb(44, 55, 66);
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(48, 49, 51);
            txtName.Hint = "";
            txtName.Location = new Point(12, 40);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(542, 38);
            txtName.TabIndex = 0;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.White;
            txtAmount.BaseColor = Color.FromArgb(44, 55, 66);
            txtAmount.BorderColorA = Color.FromArgb(64, 158, 255);
            txtAmount.BorderColorB = Color.FromArgb(220, 223, 230);
            txtAmount.Font = new Font("Segoe UI", 12F);
            txtAmount.ForeColor = Color.FromArgb(48, 49, 51);
            txtAmount.Hint = "";
            txtAmount.Location = new Point(12, 106);
            txtAmount.MaxLength = 32767;
            txtAmount.Multiline = false;
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.ScrollBars = ScrollBars.None;
            txtAmount.SelectedText = "";
            txtAmount.SelectionLength = 0;
            txtAmount.SelectionStart = 0;
            txtAmount.Size = new Size(542, 38);
            txtAmount.TabIndex = 1;
            txtAmount.TabStop = false;
            txtAmount.UseSystemPasswordChar = false;
            // 
            // hopeButton1
            // 
            hopeButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton1.Font = new Font("Segoe UI", 12F);
            hopeButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton1.Location = new Point(434, 218);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton1.Size = new Size(120, 40);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 2;
            hopeButton1.Text = "Save";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton1.Click += hopeButton1_Click;
            // 
            // txtType
            // 
            txtType.BackColor = Color.White;
            txtType.BaseColor = Color.FromArgb(44, 55, 66);
            txtType.BorderColorA = Color.FromArgb(64, 158, 255);
            txtType.BorderColorB = Color.FromArgb(220, 223, 230);
            txtType.Font = new Font("Segoe UI", 12F);
            txtType.ForeColor = Color.FromArgb(48, 49, 51);
            txtType.Hint = "";
            txtType.Location = new Point(12, 174);
            txtType.MaxLength = 32767;
            txtType.Multiline = false;
            txtType.Name = "txtType";
            txtType.PasswordChar = '\0';
            txtType.ScrollBars = ScrollBars.None;
            txtType.SelectedText = "";
            txtType.SelectionLength = 0;
            txtType.SelectionStart = 0;
            txtType.Size = new Size(542, 38);
            txtType.TabIndex = 3;
            txtType.TabStop = false;
            txtType.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Type";
            // 
            // EnterIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 270);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtType);
            Controls.Add(hopeButton1);
            Controls.Add(txtAmount);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnterIncome";
            Text = "EnterIncome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.HopeTextBox txtAmount;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.HopeTextBox txtType;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}