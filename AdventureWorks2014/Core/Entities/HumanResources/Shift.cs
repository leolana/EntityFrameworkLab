using System;

namespace AdventureWorks2014.Core.Entities.HumanResources
{
    public class Shift : Entity<byte>
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}