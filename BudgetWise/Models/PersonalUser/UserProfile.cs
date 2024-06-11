using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Models.PersonalUser
{
    public class UserProfile
    {
        [Key]
        public int ProfileID { get; set; }
        public int PersonalAccountID { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("PersonalAccountID")]
        public PersonalAccount Account { get; set; }
    }
}
