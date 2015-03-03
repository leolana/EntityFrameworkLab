using System.Xml.Linq;

namespace AdventureWorks2014.Core.Entities.HumanResources
{
    public class JobCandidate : Entity<int>
    {
        public virtual Employee Employee { get; set; }
        public XDocument Resume { get; set; }
    }
}