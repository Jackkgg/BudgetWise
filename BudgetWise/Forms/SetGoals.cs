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
    public partial class SetGoals : Form
    {
        private readonly IPersonalUserRepository _personalUserRepository;
        private readonly int _id;
        public SetGoals(int id)
        {
            InitializeComponent();
            _id = id;
            _personalUserRepository = new PersonalUserRepository(new ApplicationDbContext());
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            Targets targets = new Targets();
            targets.PersonalAccountID = _id;
            targets.Necessities = Convert.ToDecimal(txtNecessities.Text);
            targets.Luxuries = Convert.ToDecimal(txtLuxuries.Text);
            targets.Future = Convert.ToDecimal(txtFuture.Text);
            _personalUserRepository.SetGoalsForUser(targets);
            this.Close();
        }
    }
}
