namespace BudgetWise.Forms
{
    partial class SignUp
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
            personalPanel = new Panel();
            label15 = new Label();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            label14 = new Label();
            btnSignUp = new ReaLTaiizor.Controls.HopeRoundButton();
            cmbYear = new ReaLTaiizor.Controls.HopeComboBox();
            cmbMonth = new ReaLTaiizor.Controls.HopeComboBox();
            cmbDay = new ReaLTaiizor.Controls.HopeComboBox();
            label6 = new Label();
            txtEmailAddress = new ReaLTaiizor.Controls.HopeTextBox();
            label5 = new Label();
            txtPhoneNumber = new ReaLTaiizor.Controls.HopeTextBox();
            label4 = new Label();
            txtLastName = new ReaLTaiizor.Controls.HopeTextBox();
            label3 = new Label();
            txtFirstName = new ReaLTaiizor.Controls.HopeTextBox();
            label2 = new Label();
            txtUsername = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            businessPanel = new Panel();
            txtCompanyTelephone = new ReaLTaiizor.Controls.HopeTextBox();
            label13 = new Label();
            btnCompanySignUp = new ReaLTaiizor.Controls.HopeRoundButton();
            cmbMonthEst = new ReaLTaiizor.Controls.HopeComboBox();
            cmbYearEst = new ReaLTaiizor.Controls.HopeComboBox();
            label7 = new Label();
            txtAddress = new ReaLTaiizor.Controls.HopeTextBox();
            label8 = new Label();
            txtCompanyEmail = new ReaLTaiizor.Controls.HopeTextBox();
            label9 = new Label();
            txtNoOfEmployees = new ReaLTaiizor.Controls.HopeTextBox();
            label10 = new Label();
            txtSector = new ReaLTaiizor.Controls.HopeTextBox();
            label11 = new Label();
            txtCompanyName = new ReaLTaiizor.Controls.HopeTextBox();
            label12 = new Label();
            radioPersonal = new ReaLTaiizor.Controls.HopeRadioButton();
            radioBusiness = new ReaLTaiizor.Controls.HopeRadioButton();
            personalPanel.SuspendLayout();
            businessPanel.SuspendLayout();
            SuspendLayout();
            // 
            // personalPanel
            // 
            personalPanel.Controls.Add(label15);
            personalPanel.Controls.Add(txtPassword);
            personalPanel.Controls.Add(label14);
            personalPanel.Controls.Add(btnSignUp);
            personalPanel.Controls.Add(cmbYear);
            personalPanel.Controls.Add(cmbMonth);
            personalPanel.Controls.Add(cmbDay);
            personalPanel.Controls.Add(label6);
            personalPanel.Controls.Add(txtEmailAddress);
            personalPanel.Controls.Add(label5);
            personalPanel.Controls.Add(txtPhoneNumber);
            personalPanel.Controls.Add(label4);
            personalPanel.Controls.Add(txtLastName);
            personalPanel.Controls.Add(label3);
            personalPanel.Controls.Add(txtFirstName);
            personalPanel.Controls.Add(label2);
            personalPanel.Controls.Add(txtUsername);
            personalPanel.Controls.Add(label1);
            personalPanel.Location = new Point(0, 101);
            personalPanel.Margin = new Padding(0);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(476, 575);
            personalPanel.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(40, 69);
            label15.Name = "label15";
            label15.Size = new Size(131, 12);
            label15.TabIndex = 28;
            label15.Text = "*Username is already taken!";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            label15.Visible = false;
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
            txtPassword.Location = new Point(40, 103);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(358, 38);
            txtPassword.TabIndex = 27;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(40, 83);
            label14.Name = "label14";
            label14.Size = new Size(66, 17);
            label14.TabIndex = 26;
            label14.Text = "Password";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSignUp
            // 
            btnSignUp.BorderColor = Color.FromArgb(220, 223, 230);
            btnSignUp.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSignUp.DangerColor = Color.FromArgb(245, 108, 108);
            btnSignUp.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSignUp.Font = new Font("Segoe UI", 12F);
            btnSignUp.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSignUp.InfoColor = Color.FromArgb(144, 147, 153);
            btnSignUp.Location = new Point(66, 500);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSignUp.Size = new Size(310, 40);
            btnSignUp.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSignUp.TabIndex = 25;
            btnSignUp.Text = "Sign Up";
            btnSignUp.TextColor = Color.White;
            btnSignUp.WarningColor = Color.FromArgb(230, 162, 60);
            btnSignUp.Click += btnSignUp_Click;
            // 
            // cmbYear
            // 
            cmbYear.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYear.DropDownHeight = 150;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.Font = new Font("Segoe UI", 12F);
            cmbYear.FormattingEnabled = true;
            cmbYear.IntegralHeight = false;
            cmbYear.ItemHeight = 30;
            cmbYear.Location = new Point(286, 305);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(113, 36);
            cmbYear.TabIndex = 24;
            // 
            // cmbMonth
            // 
            cmbMonth.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMonth.DropDownHeight = 150;
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FlatStyle = FlatStyle.Flat;
            cmbMonth.Font = new Font("Segoe UI", 12F);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.IntegralHeight = false;
            cmbMonth.ItemHeight = 30;
            cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonth.Location = new Point(148, 305);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(132, 36);
            cmbMonth.TabIndex = 23;
            // 
            // cmbDay
            // 
            cmbDay.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDay.DropDownHeight = 150;
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.FlatStyle = FlatStyle.Flat;
            cmbDay.Font = new Font("Segoe UI", 12F);
            cmbDay.FormattingEnabled = true;
            cmbDay.IntegralHeight = false;
            cmbDay.ItemHeight = 30;
            cmbDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cmbDay.Location = new Point(41, 305);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(101, 36);
            cmbDay.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 285);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 21;
            label6.Text = "Date of Birth";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = Color.White;
            txtEmailAddress.BaseColor = Color.FromArgb(44, 55, 66);
            txtEmailAddress.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmailAddress.BorderColorB = Color.FromArgb(220, 223, 230);
            txtEmailAddress.Font = new Font("Segoe UI", 12F);
            txtEmailAddress.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmailAddress.Hint = "";
            txtEmailAddress.Location = new Point(40, 440);
            txtEmailAddress.MaxLength = 32767;
            txtEmailAddress.Multiline = false;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PasswordChar = '\0';
            txtEmailAddress.ScrollBars = ScrollBars.None;
            txtEmailAddress.SelectedText = "";
            txtEmailAddress.SelectionLength = 0;
            txtEmailAddress.SelectionStart = 0;
            txtEmailAddress.Size = new Size(358, 38);
            txtEmailAddress.TabIndex = 20;
            txtEmailAddress.TabStop = false;
            txtEmailAddress.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 420);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 19;
            label5.Text = "Email Address";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BaseColor = Color.FromArgb(44, 55, 66);
            txtPhoneNumber.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPhoneNumber.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtPhoneNumber.ForeColor = Color.FromArgb(48, 49, 51);
            txtPhoneNumber.Hint = "";
            txtPhoneNumber.Location = new Point(40, 369);
            txtPhoneNumber.MaxLength = 32767;
            txtPhoneNumber.Multiline = false;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PasswordChar = '\0';
            txtPhoneNumber.ScrollBars = ScrollBars.None;
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.SelectionLength = 0;
            txtPhoneNumber.SelectionStart = 0;
            txtPhoneNumber.Size = new Size(358, 38);
            txtPhoneNumber.TabIndex = 18;
            txtPhoneNumber.TabStop = false;
            txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 349);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 17;
            label4.Text = "Phone Number";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BaseColor = Color.FromArgb(44, 55, 66);
            txtLastName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLastName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.ForeColor = Color.FromArgb(48, 49, 51);
            txtLastName.Hint = "";
            txtLastName.Location = new Point(41, 238);
            txtLastName.MaxLength = 32767;
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.PasswordChar = '\0';
            txtLastName.ScrollBars = ScrollBars.None;
            txtLastName.SelectedText = "";
            txtLastName.SelectionLength = 0;
            txtLastName.SelectionStart = 0;
            txtLastName.Size = new Size(358, 38);
            txtLastName.TabIndex = 16;
            txtLastName.TabStop = false;
            txtLastName.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 218);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 15;
            label3.Text = "Last Name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BaseColor = Color.FromArgb(44, 55, 66);
            txtFirstName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtFirstName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.ForeColor = Color.FromArgb(48, 49, 51);
            txtFirstName.Hint = "";
            txtFirstName.Location = new Point(40, 168);
            txtFirstName.MaxLength = 32767;
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PasswordChar = '\0';
            txtFirstName.ScrollBars = ScrollBars.None;
            txtFirstName.SelectedText = "";
            txtFirstName.SelectionLength = 0;
            txtFirstName.SelectionStart = 0;
            txtFirstName.Size = new Size(358, 38);
            txtFirstName.TabIndex = 14;
            txtFirstName.TabStop = false;
            txtFirstName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 147);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 13;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            txtUsername.Location = new Point(40, 28);
            txtUsername.MaxLength = 32767;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(358, 38);
            txtUsername.TabIndex = 12;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 8);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 6;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // businessPanel
            // 
            businessPanel.BackColor = SystemColors.Control;
            businessPanel.Controls.Add(txtCompanyTelephone);
            businessPanel.Controls.Add(label13);
            businessPanel.Controls.Add(btnCompanySignUp);
            businessPanel.Controls.Add(cmbMonthEst);
            businessPanel.Controls.Add(cmbYearEst);
            businessPanel.Controls.Add(label7);
            businessPanel.Controls.Add(txtAddress);
            businessPanel.Controls.Add(label8);
            businessPanel.Controls.Add(txtCompanyEmail);
            businessPanel.Controls.Add(label9);
            businessPanel.Controls.Add(txtNoOfEmployees);
            businessPanel.Controls.Add(label10);
            businessPanel.Controls.Add(txtSector);
            businessPanel.Controls.Add(label11);
            businessPanel.Controls.Add(txtCompanyName);
            businessPanel.Controls.Add(label12);
            businessPanel.Dock = DockStyle.Bottom;
            businessPanel.Location = new Point(0, 101);
            businessPanel.Margin = new Padding(0);
            businessPanel.Name = "businessPanel";
            businessPanel.Size = new Size(476, 575);
            businessPanel.TabIndex = 26;
            businessPanel.Visible = false;
            // 
            // txtCompanyTelephone
            // 
            txtCompanyTelephone.BackColor = Color.White;
            txtCompanyTelephone.BaseColor = Color.FromArgb(44, 55, 66);
            txtCompanyTelephone.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCompanyTelephone.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCompanyTelephone.Font = new Font("Segoe UI", 12F);
            txtCompanyTelephone.ForeColor = Color.FromArgb(48, 49, 51);
            txtCompanyTelephone.Hint = "";
            txtCompanyTelephone.Location = new Point(40, 406);
            txtCompanyTelephone.MaxLength = 32767;
            txtCompanyTelephone.Multiline = false;
            txtCompanyTelephone.Name = "txtCompanyTelephone";
            txtCompanyTelephone.PasswordChar = '\0';
            txtCompanyTelephone.ScrollBars = ScrollBars.None;
            txtCompanyTelephone.SelectedText = "";
            txtCompanyTelephone.SelectionLength = 0;
            txtCompanyTelephone.SelectionStart = 0;
            txtCompanyTelephone.Size = new Size(358, 38);
            txtCompanyTelephone.TabIndex = 27;
            txtCompanyTelephone.TabStop = false;
            txtCompanyTelephone.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(40, 386);
            label13.Name = "label13";
            label13.Size = new Size(70, 17);
            label13.TabIndex = 26;
            label13.Text = "Telephone";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCompanySignUp
            // 
            btnCompanySignUp.BorderColor = Color.FromArgb(220, 223, 230);
            btnCompanySignUp.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCompanySignUp.DangerColor = Color.FromArgb(245, 108, 108);
            btnCompanySignUp.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCompanySignUp.Font = new Font("Segoe UI", 12F);
            btnCompanySignUp.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCompanySignUp.InfoColor = Color.FromArgb(144, 147, 153);
            btnCompanySignUp.Location = new Point(66, 466);
            btnCompanySignUp.Name = "btnCompanySignUp";
            btnCompanySignUp.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnCompanySignUp.Size = new Size(310, 40);
            btnCompanySignUp.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCompanySignUp.TabIndex = 25;
            btnCompanySignUp.Text = "Sign Up";
            btnCompanySignUp.TextColor = Color.White;
            btnCompanySignUp.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // cmbMonthEst
            // 
            cmbMonthEst.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMonthEst.DropDownHeight = 150;
            cmbMonthEst.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonthEst.FlatStyle = FlatStyle.Flat;
            cmbMonthEst.Font = new Font("Segoe UI", 12F);
            cmbMonthEst.FormattingEnabled = true;
            cmbMonthEst.IntegralHeight = false;
            cmbMonthEst.ItemHeight = 30;
            cmbMonthEst.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonthEst.Location = new Point(40, 214);
            cmbMonthEst.Name = "cmbMonthEst";
            cmbMonthEst.Size = new Size(132, 36);
            cmbMonthEst.TabIndex = 23;
            // 
            // cmbYearEst
            // 
            cmbYearEst.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYearEst.DropDownHeight = 150;
            cmbYearEst.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYearEst.FlatStyle = FlatStyle.Flat;
            cmbYearEst.Font = new Font("Segoe UI", 12F);
            cmbYearEst.FormattingEnabled = true;
            cmbYearEst.IntegralHeight = false;
            cmbYearEst.ItemHeight = 30;
            cmbYearEst.Location = new Point(178, 214);
            cmbYearEst.Name = "cmbYearEst";
            cmbYearEst.Size = new Size(101, 36);
            cmbYearEst.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 133);
            label7.Name = "label7";
            label7.Size = new Size(113, 17);
            label7.TabIndex = 21;
            label7.Text = "No Of Employees";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BaseColor = Color.FromArgb(44, 55, 66);
            txtAddress.BorderColorA = Color.FromArgb(64, 158, 255);
            txtAddress.BorderColorB = Color.FromArgb(220, 223, 230);
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.ForeColor = Color.FromArgb(48, 49, 51);
            txtAddress.Hint = "";
            txtAddress.Location = new Point(40, 347);
            txtAddress.MaxLength = 32767;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.ScrollBars = ScrollBars.None;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.Size = new Size(358, 38);
            txtAddress.TabIndex = 20;
            txtAddress.TabStop = false;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 327);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 19;
            label8.Text = "Address";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCompanyEmail
            // 
            txtCompanyEmail.BackColor = Color.White;
            txtCompanyEmail.BaseColor = Color.FromArgb(44, 55, 66);
            txtCompanyEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCompanyEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCompanyEmail.Font = new Font("Segoe UI", 12F);
            txtCompanyEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtCompanyEmail.Hint = "";
            txtCompanyEmail.Location = new Point(40, 283);
            txtCompanyEmail.MaxLength = 32767;
            txtCompanyEmail.Multiline = false;
            txtCompanyEmail.Name = "txtCompanyEmail";
            txtCompanyEmail.PasswordChar = '\0';
            txtCompanyEmail.ScrollBars = ScrollBars.None;
            txtCompanyEmail.SelectedText = "";
            txtCompanyEmail.SelectionLength = 0;
            txtCompanyEmail.SelectionStart = 0;
            txtCompanyEmail.Size = new Size(358, 38);
            txtCompanyEmail.TabIndex = 18;
            txtCompanyEmail.TabStop = false;
            txtCompanyEmail.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 263);
            label9.Name = "label9";
            label9.Size = new Size(93, 17);
            label9.TabIndex = 17;
            label9.Text = "Email Address";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNoOfEmployees
            // 
            txtNoOfEmployees.BackColor = Color.White;
            txtNoOfEmployees.BaseColor = Color.FromArgb(44, 55, 66);
            txtNoOfEmployees.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNoOfEmployees.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNoOfEmployees.Font = new Font("Segoe UI", 12F);
            txtNoOfEmployees.ForeColor = Color.FromArgb(48, 49, 51);
            txtNoOfEmployees.Hint = "";
            txtNoOfEmployees.Location = new Point(40, 153);
            txtNoOfEmployees.MaxLength = 32767;
            txtNoOfEmployees.Multiline = false;
            txtNoOfEmployees.Name = "txtNoOfEmployees";
            txtNoOfEmployees.PasswordChar = '\0';
            txtNoOfEmployees.ScrollBars = ScrollBars.None;
            txtNoOfEmployees.SelectedText = "";
            txtNoOfEmployees.SelectionLength = 0;
            txtNoOfEmployees.SelectionStart = 0;
            txtNoOfEmployees.Size = new Size(358, 38);
            txtNoOfEmployees.TabIndex = 16;
            txtNoOfEmployees.TabStop = false;
            txtNoOfEmployees.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(40, 194);
            label10.Name = "label10";
            label10.Size = new Size(108, 17);
            label10.TabIndex = 15;
            label10.Text = "Date Established";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSector
            // 
            txtSector.BackColor = Color.White;
            txtSector.BaseColor = Color.FromArgb(44, 55, 66);
            txtSector.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSector.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSector.Font = new Font("Segoe UI", 12F);
            txtSector.ForeColor = Color.FromArgb(48, 49, 51);
            txtSector.Hint = "";
            txtSector.Location = new Point(40, 89);
            txtSector.MaxLength = 32767;
            txtSector.Multiline = false;
            txtSector.Name = "txtSector";
            txtSector.PasswordChar = '\0';
            txtSector.ScrollBars = ScrollBars.None;
            txtSector.SelectedText = "";
            txtSector.SelectionLength = 0;
            txtSector.SelectionStart = 0;
            txtSector.Size = new Size(358, 38);
            txtSector.TabIndex = 14;
            txtSector.TabStop = false;
            txtSector.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(40, 69);
            label11.Name = "label11";
            label11.Size = new Size(46, 17);
            label11.TabIndex = 13;
            label11.Text = "Sector";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.White;
            txtCompanyName.BaseColor = Color.FromArgb(44, 55, 66);
            txtCompanyName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCompanyName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCompanyName.Font = new Font("Segoe UI", 12F);
            txtCompanyName.ForeColor = Color.FromArgb(48, 49, 51);
            txtCompanyName.Hint = "";
            txtCompanyName.Location = new Point(40, 26);
            txtCompanyName.MaxLength = 32767;
            txtCompanyName.Multiline = false;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PasswordChar = '\0';
            txtCompanyName.ScrollBars = ScrollBars.None;
            txtCompanyName.SelectedText = "";
            txtCompanyName.SelectionLength = 0;
            txtCompanyName.SelectionStart = 0;
            txtCompanyName.Size = new Size(358, 38);
            txtCompanyName.TabIndex = 12;
            txtCompanyName.TabStop = false;
            txtCompanyName.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(40, 6);
            label12.Name = "label12";
            label12.Size = new Size(106, 17);
            label12.TabIndex = 6;
            label12.Text = "Company Name";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radioPersonal
            // 
            radioPersonal.AutoSize = true;
            radioPersonal.Checked = true;
            radioPersonal.CheckedColor = Color.FromArgb(64, 158, 255);
            radioPersonal.DisabledColor = Color.FromArgb(196, 198, 202);
            radioPersonal.DisabledStringColor = Color.FromArgb(186, 187, 189);
            radioPersonal.Enable = true;
            radioPersonal.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            radioPersonal.EnabledStringColor = Color.FromArgb(146, 146, 146);
            radioPersonal.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            radioPersonal.Font = new Font("Segoe UI", 12F);
            radioPersonal.ForeColor = Color.Black;
            radioPersonal.Location = new Point(40, 63);
            radioPersonal.Name = "radioPersonal";
            radioPersonal.Size = new Size(154, 20);
            radioPersonal.TabIndex = 0;
            radioPersonal.TabStop = true;
            radioPersonal.Text = "Personal Account";
            radioPersonal.UseVisualStyleBackColor = true;
            radioPersonal.CheckedChanged += radioPersonal_CheckedChanged;
            // 
            // radioBusiness
            // 
            radioBusiness.AutoSize = true;
            radioBusiness.CheckedColor = Color.FromArgb(64, 158, 255);
            radioBusiness.DisabledColor = Color.FromArgb(196, 198, 202);
            radioBusiness.DisabledStringColor = Color.FromArgb(186, 187, 189);
            radioBusiness.Enable = true;
            radioBusiness.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            radioBusiness.EnabledStringColor = Color.FromArgb(146, 146, 146);
            radioBusiness.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            radioBusiness.Font = new Font("Segoe UI", 12F);
            radioBusiness.ForeColor = Color.Black;
            radioBusiness.Location = new Point(243, 63);
            radioBusiness.Name = "radioBusiness";
            radioBusiness.Size = new Size(155, 20);
            radioBusiness.TabIndex = 1;
            radioBusiness.Text = "Business Account";
            radioBusiness.UseVisualStyleBackColor = true;
            radioBusiness.CheckedChanged += radioBusiness_CheckedChanged;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 676);
            Controls.Add(radioBusiness);
            Controls.Add(radioPersonal);
            Controls.Add(personalPanel);
            Controls.Add(businessPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            businessPanel.ResumeLayout(false);
            businessPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel personalPanel;
        private ReaLTaiizor.Controls.HopeRadioButton radioPersonal;
        private ReaLTaiizor.Controls.HopeRadioButton radioBusiness;
        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox txtEmailAddress;
        private Label label5;
        private ReaLTaiizor.Controls.HopeTextBox txtPhoneNumber;
        private Label label4;
        private ReaLTaiizor.Controls.HopeTextBox txtLastName;
        private Label label3;
        private ReaLTaiizor.Controls.HopeTextBox txtFirstName;
        private Label label2;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private ReaLTaiizor.Controls.HopeComboBox cmbYear;
        private ReaLTaiizor.Controls.HopeComboBox cmbMonth;
        private ReaLTaiizor.Controls.HopeComboBox cmbDay;
        private Label label6;
        private ReaLTaiizor.Controls.HopeRoundButton btnSignUp;
        private Panel businessPanel;
        private ReaLTaiizor.Controls.HopeRoundButton btnCompanySignUp;
        private ReaLTaiizor.Controls.HopeComboBox cmbMonthEst;
        private ReaLTaiizor.Controls.HopeComboBox cmbYearEst;
        private Label label7;
        private ReaLTaiizor.Controls.HopeTextBox txtAddress;
        private Label label8;
        private ReaLTaiizor.Controls.HopeTextBox txtCompanyEmail;
        private Label label9;
        private ReaLTaiizor.Controls.HopeTextBox txtNoOfEmployees;
        private Label label10;
        private ReaLTaiizor.Controls.HopeTextBox txtSector;
        private Label label11;
        private ReaLTaiizor.Controls.HopeTextBox txtCompanyName;
        private Label label12;
        private ReaLTaiizor.Controls.HopeTextBox txtCompanyTelephone;
        private Label label13;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private Label label14;
        private Label label15;
    }
}