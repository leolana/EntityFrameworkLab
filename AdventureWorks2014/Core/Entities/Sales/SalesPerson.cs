using System;
using AdventureWorks2014.Core.Entities.HumanResources;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class SalesPerson : Entity<int>
    {
        public virtual Employee BussinessEntity { get; set; }
        public virtual Territory Territory { get; set; }
        public decimal Quota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYearToDate { get; set; }
        public decimal LastSalesYear { get; set; }
        public Guid RowGuid { get; set; }
    }
}