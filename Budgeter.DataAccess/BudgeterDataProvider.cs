using Budgeter.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgeter.DataAccess
{
    public class BudgeterDataProvider
    {
        private readonly BudgeterDbContext dbContext;

        public BudgeterDataProvider(BudgeterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Cashflow> GetCashflows()
        {
            return dbContext.Cashflows.ToList();
        }
    }
}
