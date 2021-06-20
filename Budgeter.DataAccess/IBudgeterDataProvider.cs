using Budgeter.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgeter.DataAccess
{
    interface IBudgeterDataProvider
    {
        IEnumerable<Cashflow> GetCashflows();
    }
}
