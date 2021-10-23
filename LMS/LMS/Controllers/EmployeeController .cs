using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        [Route("[action]")]
        public bool AddNewEmployee([FromBody] Employee employee)
        {
            return _employeeService.AddNewEmployee(employee);
        }
        [HttpPost]
        [Route("[action]/{employeeId}")]
        public Employee DeleteEmployee(long employeeId)
        {
            return _employeeService.DeleteEmployee(employeeId);
        }
        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Employee> GetAllEmployess(int queryCode)
        {
            return _employeeService.GetAllEmployess(queryCode);
        }
        [HttpPost]
        [Route("[action]/{employeeId}")]
        public Employee GetEmployee(long employeeId)
        {
            return _employeeService.GetEmployee(employeeId);
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateEmployee([FromBody] Employee employee)
        {
            return _employeeService.UpdateEmployee(employee);
        }
    }
}
