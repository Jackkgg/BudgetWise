using BudgetWise.Interfaces;
using BudgetWise.Models;
using BudgetWise.Models.PersonalUser;
using BudgetWise.Security.Algorithms;
using BudgetWise.Security;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using BudgetWise.Models.DTOs;

namespace BudgetWise.Repositories
{
    public class PersonalUserRepository : IPersonalUserRepository
    {
        private ApplicationDbContext _context;
        private Hashing _hashing;
        public PersonalUserRepository(ApplicationDbContext context)
        {
            _context = context;
            _hashing = new Hashing(new Argon2Hash());
        }

        public bool PersonalSignUp(PersonalAccount personalAccount)
        {
            var existingAccount = _context.PersonalAccounts.Any(a => a.Username == personalAccount.Username);
            if (existingAccount)
                return false;

            _context.PersonalAccounts.Add(personalAccount);
            _context.SaveChanges();
            return true;
        }

        public bool PersonalLogin(string username, string password)
        {
             var account = _context.PersonalAccounts
                           .Where(a => a.Username == username)
                           .Select(a => new { a.Salt, a.Password })
                           .FirstOrDefault();

            if (account == null)
                return false;

            var passHash =  _hashing.HashWithSalt(password, Convert.FromBase64String(account.Salt));
            
            return account.Password == passHash;           
        }

        public void AddAuthKey(string secretKey, string username)
        {
            var user = _context.PersonalAccounts.SingleOrDefault(a => a.Username == username);
            if (user != null)
            {
                user.AuthSecret = secretKey;
                _context.SaveChanges();
            }
        }

        public string GetAuthKeyForUser(string username)
        {
            var user = _context.PersonalAccounts.FirstOrDefault(a => a.Username == username);
            if(user != null)
            {
                return user.AuthSecret;
            }
            return string.Empty;
        }

        public int GetIdByName(string username)
        {
            var user = _context.PersonalAccounts.FirstOrDefault(a => a.Username == username);
            if (user != null)
                return user.PersonalAccountID;

            return -1;
        }

        public void AddIncome(IncomeStream income)
        {
            _context.IncomeStreams.Add(income);
            _context.SaveChanges();
        }

        public PersonalAccount GetUserById(int id)
        {
            var user = _context.PersonalAccounts.FirstOrDefault(a => a.PersonalAccountID == id);
            if (user != null)
                return user;

            return null;
        }

        public List<DisplayIncomeDTO> GetIncomeForUser(int id)
        {
            return _context.IncomeStreams
                           .Where(income => income.PersonalAccountID == id)
                           .Select(income => new DisplayIncomeDTO
                           {
                               Name = income.Name,
                               Amount = income.Amount,
                               Type = income.Type
                           })
                           .ToList();
        }

        public decimal GetBudgetForUser(int id)
        {
            //Get total income
            decimal totalBudget = _context.IncomeStreams
                              .Where(i => i.PersonalAccountID == id)
                              .Sum(i => i.Amount);

            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);
            DateTime lastDayOfMonth = firstDayOfNextMonth.AddDays(-1);

            var transactionsTotal = _context.Transactions
                                    .Where(t => t.PersonalAccountID == id && t.DateEntered >= firstDayOfMonth && t.DateEntered <= lastDayOfMonth)
                                    .Sum(t => t.Amount);

            //Budget = TotalIncome - SUM(Transaction.Amount)
            return totalBudget - transactionsTotal;
        }

        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public Category GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Name == name);
            if (category != null) 
                return category;

            return null;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            if (categories != null)
                return categories;

            return null;
        }

        public List<DisplayTransactionDTO> GetTransactionsForUser(int id)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);
            DateTime lastDayOfMonth = firstDayOfNextMonth.AddDays(-1);
            var transactions = _context.Transactions
                                      .Where(t => t.PersonalAccountID == id && t.DateEntered >= firstDayOfMonth && t.DateEntered <= lastDayOfMonth)
                                      .Select(t => new DisplayTransactionDTO
                                      {
                                          Reference = t.Reference,
                                          Amount = t.Amount,
                                          Category = t.Category.Name,
                                          Date = t.DateEntered
                                      })
                                      .ToList();

            if(transactions != null)
                return transactions;

            return null;
        }

        public Dictionary<string, decimal> GetSpendingByCategory(int id)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);
            DateTime lastDayOfMonth = firstDayOfNextMonth.AddDays(-1);
            var amountSpentPerCategory = _context.Transactions
                                        .Where(t => t.PersonalAccountID == id && t.DateEntered >= firstDayOfMonth && t.DateEntered <= lastDayOfMonth)
                                        .GroupBy(t => t.CategoryID)
                                        .Select(g => new
                                        {
                                            CategoryID = g.Key,
                                            TotalAmountSpent = g.Sum(t => t.Amount)
                                        })
                                        .Join(
                                            _context.Categories,
                                            transaction => transaction.CategoryID,
                                            category => category.CategoryID,
                                            (transaction, category) => new
                                            {
                                                CategoryName = category.Name,
                                                TotalAmountSpent = transaction.TotalAmountSpent
                                            })
                                        .ToDictionary(x => x.CategoryName, x => x.TotalAmountSpent);

            return amountSpentPerCategory;
        }

        public Dictionary<int, decimal> GetSpendingByMonth(int id)
        {
            var transactionsGroupedByMonth = _context.Transactions
                .Where(t => t.PersonalAccountID == id)
                .GroupBy(t => new { t.DateEntered.Month })
                .Select(g => new
                {
                    Month = g.Key.Month,
                    TotalAmountSpent = g.Sum(t => t.Amount)
                })
                .ToDictionary(x => x.Month, x => x.TotalAmountSpent);

            return transactionsGroupedByMonth;
        }

        public void SetGoalsForUser(Targets target)
        {
            _context.Targets.Add(target);
            _context.SaveChanges();
        }

        public List<decimal> GetTargetsForUser(int id)
        {
            var target = _context.Targets
                            .Where(t => t.PersonalAccountID == id)
                            .Select(t => new { t.Necessities, t.Luxuries, t.Future })
                            .FirstOrDefault();

            if (target != null)
            {
                return new List<decimal> { target.Necessities, target.Luxuries, target.Future };
            }

            return new List<decimal>();

        }
    }
}
