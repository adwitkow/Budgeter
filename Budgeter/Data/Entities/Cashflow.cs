using Budgeter.Core.Data.XmlData.PKO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Budgeter.Core.Data.Entities
{
    class Cashflow
    {
        public DateTime Timestamp { get; set; }
        public Category Category { get; set; }
        public Location Location { get; set; }
        public Source Source { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
