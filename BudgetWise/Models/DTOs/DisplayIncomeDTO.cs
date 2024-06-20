using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Models.DTOs
{
    public class DisplayIncomeDTO
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
    }
}
