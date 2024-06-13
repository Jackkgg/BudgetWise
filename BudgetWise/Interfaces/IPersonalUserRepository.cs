using BudgetWise.Models.PersonalUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Interfaces
{
    public interface IPersonalUserRepository
    {
        bool PersonalSignUp(PersonalAccount personalAccount);
        bool PersonalLogin(string username, string password);
        void AddAuthKey(string secretKey, string username);
        string GetAuthKeyForUser(string username);
    }
}
