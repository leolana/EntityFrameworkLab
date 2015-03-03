using System;
using System.Xml;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductModel : Entity<int>
    {
        public string Name { get; set; }
        public XmlDocument CatalogDescription { get; set; }
        public XmlDocument Instructions { get; set; }
        public Guid RowGuid { get; set; }
    }
}