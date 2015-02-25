using System;

namespace AdventureWorks2014.Core.Entities
{
    public interface IAuditable
    {
        DateTime ModifiedDate { get; set; }
    }
}
