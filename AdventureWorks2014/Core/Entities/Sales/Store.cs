using System;
using System.Xml;
using AdventureWorks2014.Core.Entities.Person;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class Store : Entity<int>
    {
        public virtual BussinessEntity BussinessEntity { get; set; }
        public string Name { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public XmlDocument Demographics { get; set; }
        public Guid RowGuid { get; set; }
    }
}