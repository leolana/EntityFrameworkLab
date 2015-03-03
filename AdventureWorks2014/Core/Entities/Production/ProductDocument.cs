namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductDocument : Entity<int>
    {
        public virtual Product Product { get; set; }
        public virtual Document DocumentNode { get; set; }
    }
}