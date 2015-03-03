using System;

namespace AdventureWorks2014.Core.Entities.HumanResources
{
    public class EmployeePayHistory : Entity<int>
    {
        public DateTime RateChageDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
    }
}