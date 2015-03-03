using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductDescription : Entity<int>
    {
        public virtual Product Product { get; set; }
        public string Description { get; set; }
        public Guid RowGuid { get; set; }
    }
}