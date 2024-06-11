using BudgetWise.Interfaces;
using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BudgetWise.Security.Algorithms
{
    internal class Argon2Hash : IHashingAlgorithm
    {
        public Tuple<string, string> Hash(string text)
        {
            var salt = GenerateSalt();

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(text))
            {
                Salt = salt,
                DegreeOfParallelism = Environment.ProcessorCount,
                MemorySize = 8192,
                Iterations = 4
            };

            byte[] hashBytes = argon2.GetBytes(32);
            string hashString = Convert.ToBase64String(hashBytes);
            string saltString = Convert.ToBase64String(salt);

            return Tuple.Create(hashString, saltString);
        }

        private static byte[] GenerateSalt(int saltLength = 16)
        {
            byte[] salt = new byte[saltLength];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public string HashWithSalt(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = Environment.ProcessorCount,
                MemorySize = 8192,
                Iterations = 4
            };

            byte[] hashBytes = argon2.GetBytes(32);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
