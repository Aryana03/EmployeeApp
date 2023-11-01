using EmployeeApp.Data;
using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class appController : ControllerBase
    {
        private readonly ILogger<appController> _logger;
        private readonly EmployeeContext _context;

        public appController(ILogger<appController> logger, EmployeeContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "Get")]
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var employees = _context.Employees.ToList();
            var employeeModels = employees.Select(employee => new EmployeeModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Department = employee.Department,
                Role = employee.Role,
                isAdmin = employee.isAdmin,
                Username = employee.Username
            });
            return employeeModels;
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeForCreation employeeForCreation)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee
                {
                    FirstName = employeeForCreation.FirstName,
                    LastName = employeeForCreation.LastName,
                    Email = employeeForCreation.Email,
                    Department = employeeForCreation.Department,
                    Role = employeeForCreation.Role,
                    isAdmin = employeeForCreation.isAdmin,
                    Username = employeeForCreation.Username,
                    Password = employeeForCreation.Password
                };

                _context.Employees.Add(employee);
                _context.SaveChanges();

                employee = _context.Employees.FirstOrDefault(e => e.Email == employeeForCreation.Email && e.Username == employeeForCreation.Username);
                var employeeCreated = new EmployeeModel
                {
                    Id = employee.Id,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    Department = employee.Department,
                    Role = employee.Role,
                    isAdmin = employee.isAdmin,
                    Username = employee.Username,
                    Password = employee.Password
                };

                return Ok(employeeCreated);

            }
            return BadRequest(ModelState);

        }
        
        [HttpGet("{id}")]
        public IActionResult GetEmployeeId(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e =>e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            var employeeToReturn = new EmployeeModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Department = employee.Department,
                Role = employee.Role,
                isAdmin = employee.isAdmin,
                Username = employee.Username,
                Password = employee.Password
            };

            return Ok(employeeToReturn);
        }

    }
}