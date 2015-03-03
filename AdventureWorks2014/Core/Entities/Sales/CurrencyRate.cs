using System;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class CurrencyRate : Entity<int>
    {
        public DateTime Date { get; set; }
        public virtual Currency FromCurrencyCode { get; set; }
        public virtual Currency ToCurrencyCode { get; set; }
        public decimal AverageDate { get; set; }
        public decimal EndOfDayRate { get; set; }
    }
}