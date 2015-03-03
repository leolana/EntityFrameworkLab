using System;

namespace AdventureWorks2014.Core.Entities.Person
{
    public class CountryRegion : IAuditable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}