using System;
using AdventureWorks2014.Core.Entities.HumanResources;

namespace AdventureWorks2014.Core.Entities.Purchasing
{
    public class PurchaseOrderHeader : Entity<int>
    {
        public byte RevisionNumber { get; set; }
        public byte Status { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
    }
}