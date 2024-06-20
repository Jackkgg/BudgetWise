using BudgetWise.Models.PersonalUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Models
{
    public class IncomeStream
    {
        [Key]
        public int IncomeStreamID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set;}
        public int PersonalAccountID { get; set; }

        [ForeignKey("PersonalAccountID")]
        public PersonalAccount Account { get; set; }

    }
}
