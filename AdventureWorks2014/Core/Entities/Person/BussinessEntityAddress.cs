using System;

namespace AdventureWorks2014.Core.Entities.Person
{
    public class BussinessEntityAddress : Entity<int>
    {
        public virtual BussinessEntity BussinessEntity { get; set; }
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public Guid RowGuid { get; set; }
    }
}