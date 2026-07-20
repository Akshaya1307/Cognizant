using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Bharath",
                Department = "IT",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 45000
            }
        };

        // GET
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // POST
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return Ok(employees);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
                return NotFound("Employee not found.");

            existingEmployee.Name = employee.Name;
            existingEmployee.Department = employee.Department;
            existingEmployee.Salary = employee.Salary;

            return Ok(employees);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found.");

            employees.Remove(employee);
            return Ok(employees);
        }
    }
}