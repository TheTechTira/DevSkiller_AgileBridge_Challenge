using BankApplicationClientModule.Model;
using Microsoft.EntityFrameworkCore;

namespace BankApplicationClientModule
{
    /// <summary>
    /// You cannot change this class, methods and properties in it!
    /// </summary>
    public class ClientModuleDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=BankAppClientModule.db");
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankClient> BankClients { get; set; }
    }
}
