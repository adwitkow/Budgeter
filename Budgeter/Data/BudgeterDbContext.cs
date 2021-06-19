using Budgeter.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgeter.Core.Data
{
    public class BudgeterDbContext : DbContext
    {
        public DbSet<Cashflow> Cashflows { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Source> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=budgeter.db");
        }
    }
}
