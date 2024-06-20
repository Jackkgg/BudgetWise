using BudgetWise.Models.PersonalUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public int CategoryID { get; set; }
        public int PersonalAccountID { get; set; }
        public DateTime DateEntered { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        [ForeignKey("PersonalAccountID")]
        public PersonalAccount Account { get; set; }
    }
}
