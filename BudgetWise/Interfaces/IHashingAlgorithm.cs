using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Interfaces
{
    public interface IHashingAlgorithm
    {
        Tuple<string,string> Hash(string text);
        string HashWithSalt(string password, byte[] salt);
    }
}
