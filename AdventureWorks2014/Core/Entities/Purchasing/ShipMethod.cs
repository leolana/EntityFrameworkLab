using System;

namespace AdventureWorks2014.Core.Entities.Purchasing
{
    public class ShipMethod : Entity<int>
    {
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public Guid Row { get; set; }
    }
}