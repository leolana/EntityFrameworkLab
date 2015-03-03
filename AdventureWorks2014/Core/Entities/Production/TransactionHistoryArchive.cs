using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class TransactionHistoryArchive : Entity<int>
    {
        public int ProductId { get; set; }
        public int ReferenceOrderId { get; set; }
        public int ReferenceOrderLineId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime TransactionType { get; set; }
        public int Quantity { get; set; }
        public decimal ActualCost { get; set; }
    }
}