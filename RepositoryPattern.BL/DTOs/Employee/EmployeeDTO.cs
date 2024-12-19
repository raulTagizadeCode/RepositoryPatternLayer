using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.DAL.Entities;
using RepositoryPattern.DAL.Enums;

namespace RepositoryPattern.BL.DTOs.Employee
{
    public class EmployeeDTO
    {   
        public string EmployeeName { get; set; }
        public EmployeePosition Position { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId {  get; set; }

    }
}
