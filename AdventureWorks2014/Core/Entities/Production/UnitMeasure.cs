using System;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class UnitMeasure : IAuditable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}