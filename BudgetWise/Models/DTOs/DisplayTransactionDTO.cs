using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Models.DTOs
{
    public class DisplayTransactionDTO
    {
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public string Category {  get; set; }
        public DateTime Date {  get; set; }
    }
}
