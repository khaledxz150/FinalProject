using LMS.Core.DTO;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public Task<bool> AddNewEmployee([FromBody] EmployeeInfoDTO employee)
        {
            return _employeeService.AddNewEmployee(employee);
        }
        [HttpPut]
        [Route("[action]/{employeeId}")]
        public bool DeleteEmployee(long employeeId)
        {
            return _employeeService.DeleteEmployee(employeeId);
        }

        [HttpPut]
        [Route("[action]/{employeeId}")]
        public bool ChangeTrainerStatus(long employeeId)
        {
            return _employeeService.ChangeTrainerStatus(employeeId);
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
        //************************************* <Role Type> **************************************************************
        [HttpPost]
        [Route("[action]")]
        public bool AddRoleType(RoleType roleType)
        {
            return _employeeService.AddRoleType(roleType);
        }
        [HttpPut]
        [Route("[action]/{roleTypeId}")]
        public bool DeleteRoleType(int roleTypeId)
        {
            return _employeeService.DeleteRoleType(roleTypeId);
        }
        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<RoleType> GetRoleTypes(int queryCode)
        {
            return _employeeService.GetRoleTypes(queryCode);
        }

        //ReturnEmployeeInfo
        [HttpPost]
        [Route("[action]/{employeeId}")]
        public List<EmployeeInfoDTO> ReturnEmployeeInfo(int employeeId)
        {
            return _employeeService.ReturnEmployeeInfo(employeeId);
        }
        [HttpDelete]
        [Route("[action]/{employeeId}")]
        public bool DeleteEmployeeFromDatabase(long employeeId)
        {
            return _employeeService.DeleteEmployeeFromDatabase(employeeId);
        }

    }
}
