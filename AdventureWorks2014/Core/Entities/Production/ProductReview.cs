using System;
using System.Collections.Generic;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductReview : Entity<int>
    {
        public virtual IEnumerable<Product> Products { get; set; }
        public string Name { get; set; }
        public DateTime ReviewDate { get; set; }
        public string EmailAddress { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
    }
}