using System;

namespace AdventureWorks2014.Core.Entities.HumanResources
{
    public class EmployeeDepartmentHistory : Entity<int>
    {
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}