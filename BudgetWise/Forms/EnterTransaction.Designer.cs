namespace BudgetWise.Forms
{
    partial class EnterTransaction
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
            txtReference = new ReaLTaiizor.Controls.HopeTextBox();
            txtAmount = new ReaLTaiizor.Controls.HopeTextBox();
            cmbCategory = new ReaLTaiizor.Controls.HopeComboBox();
            txtDate = new ReaLTaiizor.Controls.HopeTextBox();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtReference
            // 
            txtReference.BackColor = Color.White;
            txtReference.BaseColor = Color.FromArgb(44, 55, 66);
            txtReference.BorderColorA = Color.FromArgb(64, 158, 255);
            txtReference.BorderColorB = Color.FromArgb(220, 223, 230);
            txtReference.Font = new Font("Segoe UI", 12F);
            txtReference.ForeColor = Color.FromArgb(48, 49, 51);
            txtReference.Hint = "";
            txtReference.Location = new Point(12, 56);
            txtReference.MaxLength = 32767;
            txtReference.Multiline = false;
            txtReference.Name = "txtReference";
            txtReference.PasswordChar = '\0';
            txtReference.ScrollBars = ScrollBars.None;
            txtReference.SelectedText = "";
            txtReference.SelectionLength = 0;
            txtReference.SelectionStart = 0;
            txtReference.Size = new Size(656, 38);
            txtReference.TabIndex = 0;
            txtReference.TabStop = false;
            txtReference.UseSystemPasswordChar = false;
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
            txtAmount.Location = new Point(12, 133);
            txtAmount.MaxLength = 32767;
            txtAmount.Multiline = false;
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.ScrollBars = ScrollBars.None;
            txtAmount.SelectedText = "";
            txtAmount.SelectionLength = 0;
            txtAmount.SelectionStart = 0;
            txtAmount.Size = new Size(656, 38);
            txtAmount.TabIndex = 1;
            txtAmount.TabStop = false;
            txtAmount.UseSystemPasswordChar = false;
            // 
            // cmbCategory
            // 
            cmbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.ItemHeight = 30;
            cmbCategory.Location = new Point(12, 282);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(435, 36);
            cmbCategory.TabIndex = 2;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.White;
            txtDate.BaseColor = Color.FromArgb(44, 55, 66);
            txtDate.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDate.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDate.Enabled = false;
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.ForeColor = Color.FromArgb(48, 49, 51);
            txtDate.Hint = "";
            txtDate.Location = new Point(12, 212);
            txtDate.MaxLength = 32767;
            txtDate.Multiline = false;
            txtDate.Name = "txtDate";
            txtDate.PasswordChar = '\0';
            txtDate.ScrollBars = ScrollBars.None;
            txtDate.SelectedText = "";
            txtDate.SelectionLength = 0;
            txtDate.SelectionStart = 0;
            txtDate.Size = new Size(656, 38);
            txtDate.TabIndex = 3;
            txtDate.TabStop = false;
            txtDate.UseSystemPasswordChar = false;
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
            btnSave.Location = new Point(548, 330);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSave.Size = new Size(120, 40);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Reference:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 264);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Category";
            // 
            // EnterTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 382);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtDate);
            Controls.Add(cmbCategory);
            Controls.Add(txtAmount);
            Controls.Add(txtReference);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnterTransaction";
            Text = "EnterTransaction";
            Load += EnterTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtReference;
        private ReaLTaiizor.Controls.HopeTextBox txtAmount;
        private ReaLTaiizor.Controls.HopeComboBox cmbCategory;
        private ReaLTaiizor.Controls.HopeTextBox txtDate;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}