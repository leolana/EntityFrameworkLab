using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductListPriceHistory : Entity<int>
    {
        public virtual Product Product { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal ListPrice { get; set; }
    }
}