using System;

namespace AdventureWorks2014.Core.Entities
{
    public class Department
    {
        public short Id { get; set; }

        public string Name { get; set; }

        public string GroupName { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
