using BudgetWise.Models;
using BudgetWise.Models.DTOs;
using BudgetWise.Models.PersonalUser;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        int GetIdByName(string username);
        void AddIncome(IncomeStream income);
        PersonalAccount GetUserById(int id);
        List<DisplayIncomeDTO> GetIncomeForUser(int id);
        decimal GetBudgetForUser(int id);
        void AddTransaction(Transaction transaction);
        Category GetCategoryByName(string name);
        List<Category> GetAllCategories();
        List<DisplayTransactionDTO> GetTransactionsForUser(int id);
        Dictionary<string, decimal> GetSpendingByCategory(int id);
        Dictionary<int, decimal> GetSpendingByMonth(int id);
        void SetGoalsForUser(Targets target);
        List<decimal> GetTargetsForUser(int id);
    }
}
