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
using System.Xml.Linq;

namespace BudgetWise.Forms
{
    public partial class EnterTransaction : Form
    {
        private readonly IPersonalUserRepository _personalUserRepository;
        private readonly int _id;
        public EnterTransaction(int id)
        {
            InitializeComponent();
            _id = id;
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());
        }

        private void EnterTransaction_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.Date.ToString();
            List<Category> categories = _personalUserRepository.GetAllCategories();
            foreach (Category category in categories)
            {
                cmbCategory.Items.Add(category.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddIncome();
            this.Close();
        }

        private void AddIncome()
        {
            Transaction transaction = new Transaction();
            transaction.Reference = txtReference.Text;
            transaction.Amount = Convert.ToDecimal(txtAmount.Text);
            transaction.DateEntered = Convert.ToDateTime(txtDate.Text);
            transaction.Account = _personalUserRepository.GetUserById(_id);
            transaction.Category = _personalUserRepository.GetCategoryByName(cmbCategory.SelectedItem.ToString());
            _personalUserRepository.AddTransaction(transaction);
        }
    }
}
