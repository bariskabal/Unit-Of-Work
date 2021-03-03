using Microsoft.EntityFrameworkCore;
using UowApp.Entities;

namespace UowApp.DAL.Concrete.Context
{
    public class UowContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-QFDBI56; Database = UowAppDb; Trusted_Connection = True; MultipleActiveResultSets = true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Account> Accounts { get; set; }
    }
}