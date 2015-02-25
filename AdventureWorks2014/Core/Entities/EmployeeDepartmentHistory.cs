using System;

namespace AdventureWorks2014.Core.Entities
{
    public class EmployeeDepartmentHistory
    {
        public Employee Employee { get; set; }

        public virtual Department Department { get; set; }

        public Shift Shift { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}