using BudgetWise.Interfaces;
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
    //Display total budget
    //Enter Tran button
    //Enter Income button
    //Panels to visualise basic data (Spending breakdown by category, by month etc..)
    //Add category button
    //Add edit profile button.
    //Option to update any of the info such as name or contact
    //Option to delete account
    //some form of paging system or button to view trans or income
    public partial class PersonalDashboard : Form
    {
        private readonly int _id;
        private readonly IPersonalUserRepository _personalUserRepository;

        public PersonalDashboard()
        {
            InitializeComponent();
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());

            SetupDataGridView();
            IncomeGrid.DataSource = _personalUserRepository.GetIncomeForUser(_id);
        }
        public PersonalDashboard(int id)
        {
            InitializeComponent();
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());

            _id = id;
            SetupDataGridView();
            IncomeGrid.DataSource = _personalUserRepository.GetIncomeForUser(_id);
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            EnterIncome enterIncome = new EnterIncome(_id);
            enterIncome.Show();
        }

        private void SetupDataGridView()
        {
            IncomeGrid.Columns.Clear();
            IncomeGrid.RowTemplate.Height = 50;
            IncomeGrid.MultiSelect = false;

            // Define the columns
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "IncomeName";
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameColumn.FillWeight = 45F;
            nameColumn.ReadOnly = true;
            IncomeGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.HeaderText = "Amount";
            amountColumn.DataPropertyName = "Amount";
            amountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountColumn.FillWeight = 20F;
            amountColumn.ReadOnly = true;
            IncomeGrid.Columns.Add(amountColumn);

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "Type";
            typeColumn.DataPropertyName = "Type";
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeColumn.FillWeight = 20F;
            typeColumn.ReadOnly = true;
            IncomeGrid.Columns.Add(typeColumn);

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            editColumn.FillWeight = 15F;
            IncomeGrid.Columns.Add(editColumn);
        }

        private void PersonalDashboard_Load(object sender, EventArgs e)
        {
            lblBudget.Text = SetBudget().ToString();
        }

        private decimal SetBudget()
        {
            return _personalUserRepository.GetBudgetForUser(_id);
        }
    }
}
