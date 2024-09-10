using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountDetails.Data
{
    public class AccountDbContext : DbContext
    {
        private string conn = "Server=tcp:my-sql-server1234.database.windows.net,1433;Initial Catalog=Account_DetailsDB;Persist Security Info=False;User ID=dinesh08;Password=Dinesh@08;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conn);
        }
        public DbSet<AccountData> accountData{get; set;}
    }
}