using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoods { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public virtual UnitMeasure SizeUnitMeasureCode { get; set; }
        public virtual UnitMeasure WeightUnitMeasureCode { get; set; }
        public decimal Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string Line { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public virtual ProductSubcategory ProductSubCategory { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}