using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoberBackend.Data;
using SoberBackend.Models;

namespace SoberBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly SoberBackendDbContext _soberBackendDbContext;

        public EmployeesController(SoberBackendDbContext soberBackendDbContext)
        {
            _soberBackendDbContext = soberBackendDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _soberBackendDbContext.Employees.ToListAsync();
            return Ok(employees);
        }

        
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();
            await _soberBackendDbContext.Employees.AddAsync(employeeRequest);
            await _soberBackendDbContext.SaveChangesAsync();
            return Ok(employeeRequest);
        }
    }
}
