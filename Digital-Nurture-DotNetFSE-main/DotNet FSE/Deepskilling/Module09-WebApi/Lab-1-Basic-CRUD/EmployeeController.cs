using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new()
        {
            "Bharath",
            "Rahul",
            "Anjali"
        };

        // GET
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // POST
        [HttpPost]
        public IActionResult AddEmployee([FromBody] string employee)
        {
            employees.Add(employee);
            return Ok(employees);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] string employee)
        {
            if (id < 0 || id >= employees.Count)
            {
                return NotFound("Employee not found.");
            }

            employees[id] = employee;
            return Ok(employees);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id < 0 || id >= employees.Count)
            {
                return NotFound("Employee not found.");
            }

            employees.RemoveAt(id);
            return Ok(employees);
        }
    }
}