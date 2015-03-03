using System;

namespace AdventureWorks2014.Core.Entities.Person
{
    public class BussinessEntityContact
    {
        public virtual BussinessEntity BussinessEntity { get; set; }
        public virtual Person Person { get; set; }
        public virtual ContactType ContactType { get; set; }
        public Guid RowGuid { get; set; }
    }
}