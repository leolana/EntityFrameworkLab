using System;
using AdventureWorks2014.Core.Entities.Person;
using AdventureWorks2014.Core.Entities.Production;

namespace AdventureWorks2014.Core.Entities.Purchasing
{
    public class ProductVendor : IAuditable
    {
        public int ProductId { get; set; }
        public int BussinessEntityId { get; set; }
        public virtual Product Product { get; set; }
        public virtual BussinessEntity BussinessEntity { get; set; }
        public int AverageLeadTime { get; set; }
        public decimal StardardPrice { get; set; }
        public decimal LastReceiptCost { get; set; }
        public DateTime LastReceiptDate { get; set; }
        public int MinOrderQuantity { get; set; }
        public int MaxOrderQuantity { get; set; }
        public int OnOnderQuantity { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}