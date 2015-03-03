using AdventureWorks2014.Core.Entities.Person;

namespace AdventureWorks2014.Core.Entities.Purchasing
{
    public class Vendor : Entity<int>
    {
        public virtual BussinessEntity BussinessEntity { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public byte CreditRaiting { get; set; }
        public bool PreferredVendorStatus { get; set; }
        public bool ActiveFlag { get; set; }
        public string PurchasingWebServiceUrl { get; set; }
    }
}