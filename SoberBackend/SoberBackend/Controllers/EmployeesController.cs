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

        [HttpGet]
        [Route("{id}: Guid")]
        public async Task<IActionResult> GetEmployeeById([FromRoute]Guid id)
        {
            var employee = 
                await _soberBackendDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employee updateEmployeeRequest)
        {
            var employee =
                await _soberBackendDbContext.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.Name = updateEmployeeRequest.Name;
            employee.Email = updateEmployeeRequest.Email;
            employee.Salary = updateEmployeeRequest.Salary;
            employee.Phone = updateEmployeeRequest.Phone;
            employee.Department = updateEmployeeRequest.Department;

            await _soberBackendDbContext.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            var employee =
                await _soberBackendDbContext.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            _soberBackendDbContext.Employees.Remove(employee);
            await _soberBackendDbContext.SaveChangesAsync();
            return Ok(employee);
        }
    }
}
