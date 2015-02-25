using System;

namespace AdventureWorks2014.Core.Entities
{
    public class Shift
    {
        public int Id {get; set;}

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
