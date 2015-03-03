using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductSubcategory : Entity<int>
    {
        public virtual ProductCategory ProductCategory { get; set; }
        public string Name { get; set; }
        public Guid RowGuid { get; set; }
    }
}