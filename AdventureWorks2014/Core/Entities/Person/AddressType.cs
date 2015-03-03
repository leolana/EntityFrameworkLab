using System;

namespace AdventureWorks2014.Core.Entities.Person
{
    public class AddressType : Entity<int>
    {
        public string Name { get; set; }
        public Guid RowGuid { get; set; }
    }
}