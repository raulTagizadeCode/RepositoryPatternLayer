using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.BL.DTOs;
using RepositoryPattern.BL.DTOs.Department;
using RepositoryPattern.DAL.Contexts;
using RepositoryPattern.DAL.Entities;
using RepositoryPattern.DAL.Repositories.Abstractions;

namespace RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        public readonly AppDBContext _dBContext;
        public readonly IRepository<Department> _repository;

        public DepartmentsController(AppDBContext dBContext, IRepository<Department> repository = null)
        {
            _dBContext = dBContext;
            _repository = repository;
        }
        [HttpGet]
        public async Task<List<Department>> GetAll()
        {
            List<Department> departments = await _repository.GetAllAsync();
            return departments;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] DepartmentDTO departmentdto)
        {
            Department department = new Department()
            {
                DepartmentName = departmentdto.DepartmentName,
                DepartmentHead = departmentdto.DepartmentHead,
                NumberOfEmployees = departmentdto.NumberOfEmployees,
                CreatedAt = DateTime.Now,
            };

            await _repository.CreateAsync(department);
            return Ok();
        }
    }
}
