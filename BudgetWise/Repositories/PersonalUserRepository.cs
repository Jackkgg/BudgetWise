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
    }
}
