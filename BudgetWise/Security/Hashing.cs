using BudgetWise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Security
{
    public class Hashing
    {
        private readonly IHashingAlgorithm _hashingAlgorithm;

        public Hashing(IHashingAlgorithm hashingAlgorithm)
        {
            _hashingAlgorithm = hashingAlgorithm;
        }

        public Tuple<string, string> Hash(string text)
        {
            return _hashingAlgorithm.Hash(text);
        }

        public string HashWithSalt(string password, byte[] salt)
        {
            return _hashingAlgorithm.HashWithSalt(password, salt);
        }
    }
}
