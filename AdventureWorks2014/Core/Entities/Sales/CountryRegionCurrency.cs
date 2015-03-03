using System;
using AdventureWorks2014.Core.Entities.Person;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class CountryRegionCurrency : IAuditable
    {
        public string RegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public virtual CountryRegion Region { get; set; }
        public virtual Currency Currency { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}