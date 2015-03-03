using System;
using AdventureWorks2014.Core.Entities.Production;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class ShoppingCartItem : Entity<int>
    {
        public string ShoppingCartId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public DateTime DateCreated { get; set; }
    }
}