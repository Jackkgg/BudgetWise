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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dashboardTabPage = new ReaLTaiizor.Controls.HopeTabPage();
            tabMain = new TabPage();
            monthlySpendPlt = new ScottPlot.WinForms.FormsPlot();
            spendPlt = new ScottPlot.WinForms.FormsPlot();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblBudget = new ReaLTaiizor.Controls.BigLabel();
            tabPage2 = new TabPage();
            TransactionGrid = new DataGridView();
            btnEnterTransaction = new ReaLTaiizor.Controls.HopeButton();
            tabIncome = new TabPage();
            IncomeGrid = new DataGridView();
            btnEnterIncome = new ReaLTaiizor.Controls.HopeButton();
            tabGoals = new TabPage();
            btnSet = new ReaLTaiizor.Controls.HopeButton();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblFut = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblLux = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblNec = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            dashboardTabPage.SuspendLayout();
            tabMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionGrid).BeginInit();
            tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeGrid).BeginInit();
            tabGoals.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardTabPage
            // 
            dashboardTabPage.BaseColor = Color.FromArgb(44, 55, 66);
            dashboardTabPage.Controls.Add(tabMain);
            dashboardTabPage.Controls.Add(tabPage2);
            dashboardTabPage.Controls.Add(tabIncome);
            dashboardTabPage.Controls.Add(tabGoals);
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
            tabMain.Controls.Add(monthlySpendPlt);
            tabMain.Controls.Add(spendPlt);
            tabMain.Controls.Add(tableLayoutPanel1);
            tabMain.Location = new Point(0, 40);
            tabMain.Margin = new Padding(0);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(1012, 584);
            tabMain.TabIndex = 0;
            tabMain.Text = "Main";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // monthlySpendPlt
            // 
            monthlySpendPlt.DisplayScale = 1F;
            monthlySpendPlt.Location = new Point(532, 308);
            monthlySpendPlt.Name = "monthlySpendPlt";
            monthlySpendPlt.Size = new Size(468, 270);
            monthlySpendPlt.TabIndex = 3;
            // 
            // spendPlt
            // 
            spendPlt.DisplayScale = 1F;
            spendPlt.Location = new Point(6, 308);
            spendPlt.Name = "spendPlt";
            spendPlt.Size = new Size(468, 270);
            spendPlt.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lblBudget, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1006, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.BackColor = Color.Transparent;
            lblBudget.Dock = DockStyle.Fill;
            lblBudget.Font = new Font("Segoe UI", 25F);
            lblBudget.ForeColor = Color.FromArgb(80, 80, 80);
            lblBudget.Location = new Point(338, 0);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(329, 100);
            lblBudget.TabIndex = 0;
            lblBudget.Text = "0000.00";
            lblBudget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TransactionGrid);
            tabPage2.Controls.Add(btnEnterTransaction);
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1012, 584);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Transactions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TransactionGrid
            // 
            TransactionGrid.AllowUserToAddRows = false;
            TransactionGrid.AllowUserToDeleteRows = false;
            TransactionGrid.AllowUserToOrderColumns = true;
            TransactionGrid.AllowUserToResizeColumns = false;
            TransactionGrid.AllowUserToResizeRows = false;
            TransactionGrid.BorderStyle = BorderStyle.None;
            TransactionGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TransactionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            TransactionGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(44, 55, 66);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            TransactionGrid.DefaultCellStyle = dataGridViewCellStyle6;
            TransactionGrid.Dock = DockStyle.Top;
            TransactionGrid.GridColor = Color.FromArgb(224, 224, 224);
            TransactionGrid.Location = new Point(3, 3);
            TransactionGrid.Margin = new Padding(0);
            TransactionGrid.Name = "TransactionGrid";
            TransactionGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            TransactionGrid.RowHeadersVisible = false;
            TransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionGrid.Size = new Size(1006, 509);
            TransactionGrid.TabIndex = 2;
            // 
            // btnEnterTransaction
            // 
            btnEnterTransaction.BackColor = Color.FromArgb(44, 55, 66);
            btnEnterTransaction.BorderColor = Color.FromArgb(220, 223, 230);
            btnEnterTransaction.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEnterTransaction.DangerColor = Color.FromArgb(245, 108, 108);
            btnEnterTransaction.DefaultColor = Color.FromArgb(255, 255, 255);
            btnEnterTransaction.Font = new Font("Segoe UI", 12F);
            btnEnterTransaction.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEnterTransaction.InfoColor = Color.FromArgb(144, 147, 153);
            btnEnterTransaction.Location = new Point(12, 525);
            btnEnterTransaction.Name = "btnEnterTransaction";
            btnEnterTransaction.PrimaryColor = Color.FromArgb(44, 55, 66);
            btnEnterTransaction.Size = new Size(988, 47);
            btnEnterTransaction.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEnterTransaction.TabIndex = 1;
            btnEnterTransaction.Text = "Enter Transaction";
            btnEnterTransaction.TextColor = Color.White;
            btnEnterTransaction.WarningColor = Color.FromArgb(230, 162, 60);
            btnEnterTransaction.Click += btnEnterTransaction_Click;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            IncomeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            IncomeGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(44, 55, 66);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            IncomeGrid.DefaultCellStyle = dataGridViewCellStyle8;
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
            // tabGoals
            // 
            tabGoals.Controls.Add(btnSet);
            tabGoals.Controls.Add(formsPlot1);
            tabGoals.Controls.Add(tableLayoutPanel3);
            tabGoals.Controls.Add(tableLayoutPanel2);
            tabGoals.Location = new Point(0, 40);
            tabGoals.Name = "tabGoals";
            tabGoals.Padding = new Padding(3);
            tabGoals.Size = new Size(1012, 584);
            tabGoals.TabIndex = 3;
            tabGoals.Text = "Goals";
            tabGoals.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            btnSet.BorderColor = Color.FromArgb(220, 223, 230);
            btnSet.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSet.DangerColor = Color.FromArgb(245, 108, 108);
            btnSet.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSet.Font = new Font("Segoe UI", 12F);
            btnSet.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSet.InfoColor = Color.FromArgb(144, 147, 153);
            btnSet.Location = new Point(843, 129);
            btnSet.Name = "btnSet";
            btnSet.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSet.Size = new Size(151, 45);
            btnSet.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSet.TabIndex = 3;
            btnSet.Text = "Set Goals";
            btnSet.TextColor = Color.White;
            btnSet.WarningColor = Color.FromArgb(230, 162, 60);
            btnSet.Click += btnSet_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(311, 180);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(689, 392);
            formsPlot1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Location = new Point(311, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(689, 119);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(lblFut, 0, 1);
            tableLayoutPanel7.Controls.Add(bigLabel3, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(461, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(225, 113);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // lblFut
            // 
            lblFut.AutoSize = true;
            lblFut.BackColor = Color.Transparent;
            lblFut.Dock = DockStyle.Fill;
            lblFut.Font = new Font("Segoe UI", 25F);
            lblFut.ForeColor = Color.FromArgb(80, 80, 80);
            lblFut.Location = new Point(3, 56);
            lblFut.Name = "lblFut";
            lblFut.Size = new Size(219, 57);
            lblFut.TabIndex = 2;
            lblFut.Text = "0%";
            lblFut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Dock = DockStyle.Fill;
            bigLabel3.Font = new Font("Segoe UI", 25F);
            bigLabel3.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel3.Location = new Point(3, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(219, 56);
            bigLabel3.TabIndex = 1;
            bigLabel3.Text = "Future";
            bigLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(lblLux, 0, 1);
            tableLayoutPanel6.Controls.Add(bigLabel2, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(232, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(223, 113);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // lblLux
            // 
            lblLux.AutoSize = true;
            lblLux.BackColor = Color.Transparent;
            lblLux.Dock = DockStyle.Fill;
            lblLux.Font = new Font("Segoe UI", 25F);
            lblLux.ForeColor = Color.FromArgb(80, 80, 80);
            lblLux.Location = new Point(3, 56);
            lblLux.Name = "lblLux";
            lblLux.Size = new Size(217, 57);
            lblLux.TabIndex = 2;
            lblLux.Text = "0%";
            lblLux.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Dock = DockStyle.Fill;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(3, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(217, 56);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "Luxuries";
            bigLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblNec, 0, 1);
            tableLayoutPanel4.Controls.Add(bigLabel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(223, 113);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblNec
            // 
            lblNec.AutoSize = true;
            lblNec.BackColor = Color.Transparent;
            lblNec.Dock = DockStyle.Fill;
            lblNec.Font = new Font("Segoe UI", 25F);
            lblNec.ForeColor = Color.FromArgb(80, 80, 80);
            lblNec.Location = new Point(3, 56);
            lblNec.Name = "lblNec";
            lblNec.Size = new Size(217, 57);
            lblNec.TabIndex = 1;
            lblNec.Text = "0%";
            lblNec.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Dock = DockStyle.Fill;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(3, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(217, 56);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Necessities";
            bigLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Location = new Point(6, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(299, 566);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TransactionGrid).EndInit();
            tabIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IncomeGrid).EndInit();
            tabGoals.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private ReaLTaiizor.Controls.HopeButton btnEnterTransaction;
        private DataGridView TransactionGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot spendPlt;
        private ScottPlot.WinForms.FormsPlot monthlySpendPlt;
        private TabPage tabGoals;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ReaLTaiizor.Controls.HopeButton btnSet;
        private TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.BigLabel lblFut;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.BigLabel lblLux;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.BigLabel lblNec;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private TableLayoutPanel tableLayoutPanel5;
    }
}