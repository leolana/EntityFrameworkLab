using System;
using AdventureWorks2014.Core.Entities.Person;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class SalesTaxRate : Entity<int>
    {
        public virtual StateProvince StateProvince { get; set; }
        public byte TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public string Name { get; set; }
        public Guid RowGuid { get; set; }
    }
}