using System;
using AdventureWorks2014.Core.Entities.Person;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class Territory : Entity<int>
    {
        public string Name { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public string Group { get; set; }
        public decimal SalesYearToDate { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYearToDate { get; set; }
        public decimal CostLastYear { get; set; }
        public Guid RowGuid { get; set; }
    }
}