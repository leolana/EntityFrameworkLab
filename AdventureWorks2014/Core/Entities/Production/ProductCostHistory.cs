using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductCostHistory : Entity<int>
    {
        public virtual Product Product { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal StandardCost { get; set; }
    }
}