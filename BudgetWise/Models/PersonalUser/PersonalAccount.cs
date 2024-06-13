using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Models.PersonalUser
{
    public class PersonalAccount
    {
        [Key]
        public int PersonalAccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string AuthSecret {  get; set; }
        public UserProfile Profile { get; set; }
    }
}
