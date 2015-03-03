using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductCategory : Entity<int>
    {
        public string Name { get; set; }
        public Guid RowGuid { get; set; }
    }
}