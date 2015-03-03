using System;

namespace AdventureWorks2014.Core.Entities.Person
{
    public class Password : Entity<int>
    {
        public virtual BussinessEntity BussinessEntity { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public Guid RowGuid { get; set; }
    }
}