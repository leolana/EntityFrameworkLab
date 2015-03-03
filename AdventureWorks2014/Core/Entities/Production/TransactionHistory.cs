using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class TransactionHistory : Entity<int>
    {
        public virtual Product Product { get; set; }
        public int ReferenceOrderId { get; set; }
        public int ReferenceOrderLineId { get; set; }
        public DateTime Date { get; set; }
        public char Type { get; set; }
        public int Quantity { get; set; }
        public decimal ActualCost { get; set; }
    }
}