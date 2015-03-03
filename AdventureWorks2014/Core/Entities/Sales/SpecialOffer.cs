using System;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class SpecialOffer : Entity<int>
    {
        public string Description { get; set; }
        public decimal DisountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public Guid RowGuid { get; set; }
    }
}