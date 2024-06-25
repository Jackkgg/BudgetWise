using BudgetWise.Interfaces;
using BudgetWise.Models;
using BudgetWise.Repositories;
using BudgetWise.Utilities;
using ScottPlot;
using ScottPlot.WinForms;
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

        public PersonalDashboard(int id)
        {
            InitializeComponent();
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());

            _id = id;
            SetupIncomeGrid();
            SetupTransactionGrid();
            LoadChartData();
            SetTargetAllocations();
            IncomeGrid.DataSource = _personalUserRepository.GetIncomeForUser(_id);
            TransactionGrid.DataSource = _personalUserRepository.GetTransactionsForUser(_id);

        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            EnterIncome enterIncome = new EnterIncome(_id);
            enterIncome.Show();
        }



        private void PersonalDashboard_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string currentMonth = now.ToString("MMMM");
            string budget = SetBudget().ToString();

            lblBudget.Text = $"Budget for {currentMonth}: {budget}";
        }

        private decimal SetBudget()
        {
            return _personalUserRepository.GetBudgetForUser(_id);
        }

        private void btnEnterTransaction_Click(object sender, EventArgs e)
        {
            this.Close();
            EnterTransaction enterTransaction = new EnterTransaction(_id);
            enterTransaction.Show();
        }

        private void SetupIncomeGrid()
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
        private void SetupTransactionGrid()
        {
            TransactionGrid.Columns.Clear();
            TransactionGrid.RowTemplate.Height = 50;
            TransactionGrid.MultiSelect = false;

            // Define the columns
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Reference";
            nameColumn.HeaderText = "Reference";
            nameColumn.DataPropertyName = "Reference";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameColumn.FillWeight = 45F;
            nameColumn.ReadOnly = true;
            TransactionGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.HeaderText = "Amount";
            amountColumn.DataPropertyName = "Amount";
            amountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountColumn.FillWeight = 20F;
            amountColumn.ReadOnly = true;
            TransactionGrid.Columns.Add(amountColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "Date";
            dateColumn.DataPropertyName = "Date";
            dateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateColumn.FillWeight = 20F;
            dateColumn.ReadOnly = true;
            TransactionGrid.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.Name = "Category";
            categoryColumn.HeaderText = "Category";
            categoryColumn.DataPropertyName = "Category";
            categoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryColumn.FillWeight = 20F;
            categoryColumn.ReadOnly = true;
            TransactionGrid.Columns.Add(categoryColumn);
        }
        private void LoadChartData()
        {
            ChartingLibrary chartingLibrary = new ChartingLibrary();
            chartingLibrary.SpendingByCategoryBar(spendPlt, _personalUserRepository, _id);
            chartingLibrary.SpendingByMonthBar(monthlySpendPlt, _personalUserRepository, _id);
        }
        private void SetTargetAllocations()
        {
            List<decimal> allocations = _personalUserRepository.GetTargetsForUser(_id);
            lblNec.Text = $"{allocations[0]}%";
            lblLux.Text = $"{allocations[1]}%";
            lblFut.Text = $"{allocations[2]}%";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            SetGoals setGoals = new SetGoals(_id);
            setGoals.Show();
        }
    }
}
