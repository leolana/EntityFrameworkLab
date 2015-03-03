using System;

namespace AdventureWorks2014.Core.Entities.Sales
{
    public class Currency : IAuditable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}