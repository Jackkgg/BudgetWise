using BudgetWise.Forms;
using BudgetWise.Interfaces;
using BudgetWise.Models;
using BudgetWise.Repositories;
using BudgetWise.Security;
using BudgetWise.Security.Algorithms;
using Microsoft.EntityFrameworkCore;

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
            if (_personalUserRepository.PersonalLogin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Account not found!");
            }
        }
    }
}
