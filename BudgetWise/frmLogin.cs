using BudgetWise.Forms;
using BudgetWise.Interfaces;
using BudgetWise.Models;
using BudgetWise.Repositories;
using BudgetWise.Security;
using BudgetWise.Security.Algorithms;
using Google.Authenticator;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System.Net;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace BudgetWise
{
    public partial class frmLogin : Form
    {
        private readonly IPersonalUserRepository _personalUserRepository;

        public frmLogin()
        {
            InitializeComponent();
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var key = _personalUserRepository.GetAuthKeyForUser(txtUsername.Text);
            AuthenticateUser authenticateUser = new AuthenticateUser(key);
            if (_personalUserRepository.PersonalLogin(txtUsername.Text, txtPassword.Text))
            {
                authenticateUser.Show();
            }
            else
            {
                MessageBox.Show("Account not found!");
            }
        }
    }
}
