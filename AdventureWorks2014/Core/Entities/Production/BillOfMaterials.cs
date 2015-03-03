using System;
using System.Collections.Generic;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class BillOfMaterials : Entity<int>
    {
        public virtual IEnumerable<Product> ProductAssembly { get; set; }
        public virtual IEnumerable<Product> Components { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual UnitMeasure UnitMeasureCode { get; set; }
        public short BOMLevel { get; set; }
        public decimal PerAssemblyQuantity { get; set; }
    }
}