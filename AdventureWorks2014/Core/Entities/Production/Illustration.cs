using System.Xml;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class Illustration : Entity<int>
    {
        public XmlDocument Diagram { get; set; }
    }
}