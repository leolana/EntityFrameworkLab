using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class WorkOrder : Entity<int>
    {
        public virtual Product Product { get; set; }
        public int OrderQuantity { get; set; }
        public int StockedQuantity { get; set; }
        public short ScrappedQuantity { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DueDate { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
    }
}