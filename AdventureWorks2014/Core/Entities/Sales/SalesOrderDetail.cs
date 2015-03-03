using System;
using AdventureWorks2014.Core.Entities.Production;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class SalesOrderDetail : Entity<int>
    {
        public virtual SalesOrderHeader SalesOrder { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQuantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public decimal LineTotal { get; set; }
        public Guid RowGuid { get; set; }
    }
}