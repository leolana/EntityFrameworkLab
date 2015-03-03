namespace AdventureWorks2014.Core.Entities.Production
{
    public class Location : Entity<short>
    {
        public string Name { get; set; }
        public decimal CostRate { get; set; }
        public decimal Availability { get; set; }
    }
}