using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetWise.Models.PersonalUser;
using Microsoft.EntityFrameworkCore;

namespace BudgetWise.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = ConfigurationManager.ConnectionStrings["AzureDbConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<PersonalAccount> PersonalAccounts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
