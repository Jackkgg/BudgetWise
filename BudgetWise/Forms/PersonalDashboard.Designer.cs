namespace BudgetWise.Forms
{
    partial class PersonalDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dashboardTabPage = new ReaLTaiizor.Controls.HopeTabPage();
            tabMain = new TabPage();
            tabPage2 = new TabPage();
            tabIncome = new TabPage();
            IncomeGrid = new DataGridView();
            btnEnterIncome = new ReaLTaiizor.Controls.HopeButton();
            lblBudget = new ReaLTaiizor.Controls.BigLabel();
            dashboardTabPage.SuspendLayout();
            tabMain.SuspendLayout();
            tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeGrid).BeginInit();
            SuspendLayout();
            // 
            // dashboardTabPage
            // 
            dashboardTabPage.BaseColor = Color.FromArgb(44, 55, 66);
            dashboardTabPage.Controls.Add(tabMain);
            dashboardTabPage.Controls.Add(tabPage2);
            dashboardTabPage.Controls.Add(tabIncome);
            dashboardTabPage.Dock = DockStyle.Fill;
            dashboardTabPage.Font = new Font("Segoe UI", 12F);
            dashboardTabPage.ForeColorA = Color.Silver;
            dashboardTabPage.ForeColorB = Color.Gray;
            dashboardTabPage.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            dashboardTabPage.ItemSize = new Size(120, 40);
            dashboardTabPage.Location = new Point(0, 0);
            dashboardTabPage.Margin = new Padding(0);
            dashboardTabPage.Name = "dashboardTabPage";
            dashboardTabPage.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            dashboardTabPage.SelectedIndex = 0;
            dashboardTabPage.Size = new Size(1012, 624);
            dashboardTabPage.SizeMode = TabSizeMode.Fixed;
            dashboardTabPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            dashboardTabPage.TabIndex = 0;
            dashboardTabPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            dashboardTabPage.ThemeColorA = Color.FromArgb(64, 158, 255);
            dashboardTabPage.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            dashboardTabPage.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(lblBudget);
            tabMain.Location = new Point(0, 40);
            tabMain.Margin = new Padding(0);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(1012, 584);
            tabMain.TabIndex = 0;
            tabMain.Text = "Main";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1012, 584);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Transactions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabIncome
            // 
            tabIncome.Controls.Add(IncomeGrid);
            tabIncome.Controls.Add(btnEnterIncome);
            tabIncome.Location = new Point(0, 40);
            tabIncome.Margin = new Padding(0);
            tabIncome.Name = "tabIncome";
            tabIncome.Padding = new Padding(3);
            tabIncome.Size = new Size(1012, 584);
            tabIncome.TabIndex = 2;
            tabIncome.Text = "Income";
            tabIncome.UseVisualStyleBackColor = true;
            // 
            // IncomeGrid
            // 
            IncomeGrid.AllowUserToAddRows = false;
            IncomeGrid.AllowUserToDeleteRows = false;
            IncomeGrid.AllowUserToOrderColumns = true;
            IncomeGrid.AllowUserToResizeColumns = false;
            IncomeGrid.AllowUserToResizeRows = false;
            IncomeGrid.BorderStyle = BorderStyle.None;
            IncomeGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            IncomeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            IncomeGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(44, 55, 66);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            IncomeGrid.DefaultCellStyle = dataGridViewCellStyle4;
            IncomeGrid.Dock = DockStyle.Top;
            IncomeGrid.GridColor = Color.FromArgb(224, 224, 224);
            IncomeGrid.Location = new Point(3, 3);
            IncomeGrid.Margin = new Padding(0);
            IncomeGrid.Name = "IncomeGrid";
            IncomeGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            IncomeGrid.RowHeadersVisible = false;
            IncomeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IncomeGrid.Size = new Size(1006, 509);
            IncomeGrid.TabIndex = 1;
            // 
            // btnEnterIncome
            // 
            btnEnterIncome.BackColor = Color.FromArgb(44, 55, 66);
            btnEnterIncome.BorderColor = Color.FromArgb(220, 223, 230);
            btnEnterIncome.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEnterIncome.DangerColor = Color.FromArgb(245, 108, 108);
            btnEnterIncome.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEnterIncome.Font = new Font("Segoe UI", 12F);
            btnEnterIncome.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEnterIncome.InfoColor = Color.FromArgb(144, 147, 153);
            btnEnterIncome.Location = new Point(12, 525);
            btnEnterIncome.Name = "btnEnterIncome";
            btnEnterIncome.PrimaryColor = Color.FromArgb(44, 55, 66);
            btnEnterIncome.Size = new Size(988, 47);
            btnEnterIncome.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEnterIncome.TabIndex = 0;
            btnEnterIncome.Text = "Enter Income";
            btnEnterIncome.TextColor = Color.White;
            btnEnterIncome.WarningColor = Color.FromArgb(230, 162, 60);
            btnEnterIncome.Click += hopeButton1_Click;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.BackColor = Color.Transparent;
            lblBudget.Font = new Font("Segoe UI", 25F);
            lblBudget.ForeColor = Color.FromArgb(80, 80, 80);
            lblBudget.Location = new Point(419, 33);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(135, 46);
            lblBudget.TabIndex = 0;
            lblBudget.Text = "0000.00";
            lblBudget.TextAlign = ContentAlignment.TopCenter;
            // 
            // PersonalDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 624);
            Controls.Add(dashboardTabPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalDashboard";
            Text = "PersonalDashboard";
            Load += PersonalDashboard_Load;
            dashboardTabPage.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabMain.PerformLayout();
            tabIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IncomeGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage dashboardTabPage;
        private TabPage tabMain;
        private TabPage tabPage2;
        private TabPage tabIncome;
        private ReaLTaiizor.Controls.HopeButton btnEnterIncome;
        private DataGridView IncomeGrid;
        private ReaLTaiizor.Controls.BigLabel lblBudget;
    }
}