using BudgetWise.Interfaces;
using BudgetWise.Models;
using BudgetWise.Models.PersonalUser;
using BudgetWise.Repositories;
using BudgetWise.Security;
using BudgetWise.Security.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetWise.Forms
{
    public partial class SignUp : Form
    {
        private readonly IPersonalUserRepository _personalUserRepository;
        private readonly Hashing _hashing;
        private readonly frmLogin _login;
        public SignUp(frmLogin login)
        {
            InitializeComponent();
            personalPanel.Visible = true;
            businessPanel.Visible = false;

            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());
            _hashing = new Hashing(new Argon2Hash());
            _login = login;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i.ToString());
                cmbYearEst.Items.Add(i.ToString());
            }
        }

        private void radioPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPersonal.Checked)
            {
                personalPanel.Visible = true;
                businessPanel.Visible = false;
            }
        }

        private void radioBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBusiness.Checked)
            {
                businessPanel.Visible = true;
                personalPanel.Visible = false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var hashedInfo = _hashing.Hash(txtPassword.Text);


            var account = new PersonalAccount
            {
                Username = txtUsername.Text,
                Password = hashedInfo.Item1,
                Salt = hashedInfo.Item2,
            };

            var profile = new UserProfile
            {
                Username = account.Username,
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Telephone = txtPhoneNumber.Text,
                Email = txtEmailAddress.Text,
                DateOfBirth = SetDateOfBirth(),
            };

            account.Profile = profile;

            if (!_personalUserRepository.PersonalSignUp(account))
            {
                label15.Visible = true;
                return;
            }

            this.Close();
            _login.Show();
        }

        private DateTime SetDateOfBirth()
        {
            string day = cmbDay.Text;
            string month = cmbMonth.Text;
            string year = cmbYear.Text;

            string date = $"{day} {month} {year}";
            DateTime dateOfBirth = DateTime.ParseExact(date, "dd MMMM yyyy", CultureInfo.InvariantCulture);

            return dateOfBirth.Date;
        }
    }
}
