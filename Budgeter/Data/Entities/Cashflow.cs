using System;

namespace Budgeter.Core.Data.Entities
{
    public class Cashflow
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
