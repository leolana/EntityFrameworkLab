namespace AdventureWorks2014.Core.Entities.Sales
{
    public class SalesReason : Entity<int>
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}