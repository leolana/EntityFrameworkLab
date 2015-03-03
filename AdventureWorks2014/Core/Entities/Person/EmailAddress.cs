using System;

namespace AdventureWorks2014.Core.Entities.Person
{
    public class EmailAddress : Entity<int>
    {
        public int BussinessEntityId { get; set; }
        public virtual BussinessEntity BussinessEntity { get; set; }
        public string Email { get; set; }
        public Guid RowGuid { get; set; }
    }
}