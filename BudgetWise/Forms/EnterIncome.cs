using BudgetWise.Interfaces;
using BudgetWise.Migrations;
using BudgetWise.Models;
using BudgetWise.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetWise.Forms
{
    public partial class EnterIncome : Form
    {
        private readonly IPersonalUserRepository _userRepository;
        private readonly int _id;
        public EnterIncome(int id)
        {
            InitializeComponent();
            _userRepository = new PersonalUserRepository(new ApplicationDbContext());
            _id = id;
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            AddIncome();
            this.Close();
            PersonalDashboard personalDashboard = new PersonalDashboard(_id);
            personalDashboard.Show();
        }

        private void AddIncome()
        {
            IncomeStream income = new IncomeStream();
            income.Name = txtName.Text;
            income.Amount = Convert.ToDecimal(txtAmount.Text);
            income.Type = txtType.Text;
            income.Account = _userRepository.GetUserById(_id);
            _userRepository.AddIncome(income);
        }
    }
}
