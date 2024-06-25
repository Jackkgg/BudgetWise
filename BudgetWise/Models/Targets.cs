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
    public class Targets
    {
        [Key]
        public int TargetID { get; set; }
        public int PersonalAccountID { get; set; }
        public decimal Necessities { get; set; }
        public decimal Luxuries { get; set; }
        public decimal Future { get; set; }

        [ForeignKey("PersonalAccountID")]
        public PersonalAccount Account { get; set; }
    }
}
