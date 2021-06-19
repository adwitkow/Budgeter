using Budgeter.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Budgeter.Core.Data
{
    public class BudgeterDbContext : DbContext
    {
        public BudgeterDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Cashflow> Cashflows { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Source> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=budgeter.db");
        }
    }
}
