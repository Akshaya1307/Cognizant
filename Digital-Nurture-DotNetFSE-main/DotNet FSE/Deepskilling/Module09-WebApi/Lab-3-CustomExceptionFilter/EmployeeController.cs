using FirstWebApi.Filters;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                Department = new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "ASP.NET Core" }
                },
                DateOfBirth = new DateTime(1998, 5, 20)
            },
            new Employee
            {
                Id = 2,
                Name = "Kumar Raja",
                Salary = 60000,
                Permanent = true,
                Department = new Department
                {
                    Id = 2,
                    Name = "Data Science"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "Python" },
                    new Skill { Id = 4, Name = "SQL" }
                },
                DateOfBirth = new DateTime(2002, 11, 1)
            }
        };

        private List<Employee> GetStandardEmployeeList()
        {
            return employees;
        }

        // GET
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            // Uncomment this line to test the Custom Exception Filter
            // throw new Exception("This is a custom exception for testing.");

            return Ok(GetStandardEmployeeList());
        }

        // POST
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return NotFound("Employee not found.");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth;

            return Ok(existingEmployee);
        }
    }
}