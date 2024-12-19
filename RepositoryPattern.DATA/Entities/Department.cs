using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Entities
{
    public class Department:AuditableEntity
    {
        public string DepartmentName {  get; set; }
        public string DepartmentHead { get; set; }
        public string NumberOfEmployees { get;set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
