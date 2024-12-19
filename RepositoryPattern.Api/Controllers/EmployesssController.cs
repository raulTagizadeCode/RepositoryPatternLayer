using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.BL.DTOs.Employee;
using RepositoryPattern.DAL.Contexts;
using RepositoryPattern.DAL.Entities;
using RepositoryPattern.DAL.Repositories.Abstractions;

namespace RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployesssController : ControllerBase
    {
        
        public readonly IRepository<Employee> _repository;

        public EmployesssController(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Employee>> GetAll()
        {
            List<Employee> employees = await _repository.GetAllAsync();
            return employees;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee()
            {
                EmployeeName = employeeDTO.EmployeeName,
                Salary = employeeDTO.Salary,
                Position = employeeDTO.Position,
                CreatedAt = DateTime.Now,
                DepartmentId=employeeDTO.DepartmentId,
            };

            await _repository.CreateAsync(employee);
            return Ok();
        }
    }
}
    