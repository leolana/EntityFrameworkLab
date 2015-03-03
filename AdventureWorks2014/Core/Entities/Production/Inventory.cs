using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public string Shelf { get; set; }
        public byte Bin { get; set; }
        public short Quantity { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}