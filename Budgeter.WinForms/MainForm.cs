using Budgeter.Core.Data;
using Budgeter.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Budgeter.WinForms
{
    public partial class MainForm : Form
    {
        private readonly BudgeterDbContext dbContext;
        private List<Cashflow> Cashflows = new List<Cashflow>();

        public MainForm(BudgeterDbContext dbContext)
        {
            this.dbContext = dbContext;

            dbContext.Cashflows.Add(new Cashflow() { Timestamp = DateTime.UtcNow, Currency = "PLN", Amount = 10 });

            dbContext.SaveChanges();

            InitializeComponent();
        }
    }
}
