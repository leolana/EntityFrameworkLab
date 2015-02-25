using System;

namespace AdventureWorks2014.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string NationalIDNumber { get; set; }

        public string LoginID { get; set; }

        public string OrganizationNode { get; set; }

        public short OrganizationLevel { get; set; }

        public string JobTitle { get; set; }

        public DateTime BirthDate { get; set; }

        public char MaritalStatus { get; set; }

        public char Gender { get; set; }

        public DateTime HireDate { get; set; }

        public bool SalariedFlag { get; set; }

        public short VacationHours { get; set; }

        public short SickLeaveHours { get; set; }

        public bool CurrentFlag { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}