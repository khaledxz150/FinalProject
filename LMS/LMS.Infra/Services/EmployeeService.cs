using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public bool AddNewEmployee(Employee employee)
        {
            return _employeeRepository.AddNewEmployee(employee);
        }

        public Employee DeleteEmployee(long employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }

        public List<Employee> GetAllEmployess(int queryCode)
        {
            return _employeeRepository.GetAllEmployess(queryCode);
        }

        public Employee GetEmployee(long employeeId)
        {
            return _employeeRepository.GetEmployee(employeeId);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }
        //Role Type

        public bool AddRoleType(RoleType roleType)
        {
            return _employeeRepository.AddRoleType(roleType);
        }
        public bool DeleteRoleType(int roleTypeId)
        {
            return _employeeRepository.DeleteRoleType(roleTypeId);
        }
        public List<RoleType> GetRoleTypes(int queryCode)
        {
            return _employeeRepository.GetRoleTypes(queryCode);
        }
    }
}
