using System;

namespace AdventureWorks2014.Core.Entities
{
    public class Entity<T> : IAuditable
        where T : struct
    {
        public T Id { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}