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
            optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
        }

        public DbSet<PersonalAccount> PersonalAccounts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<IncomeStream> IncomeStreams { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Targets> Targets { get; set; }
    }
}
