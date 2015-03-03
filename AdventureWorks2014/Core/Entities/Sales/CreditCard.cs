namespace AdventureWorks2014.Core.Entities.Sales
{
    public class CreditCard : Entity<int>
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public byte ExpirationMonth { get; set; }
        public short ExpirationYear { get; set; }
    }
}