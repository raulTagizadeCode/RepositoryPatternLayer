using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.DAL.Enums;

namespace RepositoryPattern.DAL.Entities
{
    public class Employee:AuditableEntity
    {
        public string EmployeeName { get; set; }
        public EmployeePosition Position {  get; set; }
        public decimal Salary {  get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

    }
}
