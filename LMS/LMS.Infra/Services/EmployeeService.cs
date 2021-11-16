using LMS.Core.Data;
using LMS.Core.DTO;
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

        public Task<bool> AddNewEmployee(EmployeeInfoDTO employee)
        {
            return _employeeRepository.AddNewEmployee(employee);
        }

        public bool DeleteEmployee(long employeeId)
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

        public List<EmployeeInfoDTO> ReturnEmployeeInfo(int employeeId)
        {
            return _employeeRepository.ReturnEmployeeInfo(employeeId);
        }

        public bool ChangeTrainerStatus(long employeeId)
        {
           return  _employeeRepository.ChangeTrainerStatus(employeeId);
        }

        public bool DeleteEmployeeFromDatabase(long employeeId)
        {
            return _employeeRepository.DeleteEmployeeFromDatabase(employeeId);
        }



        public bool AddAttendanceTrainee(List<Attendance_Tup> att)

        {
            return _employeeRepository.AddAttendanceTrainee(att);
        }

       

        public List<TraineeAttendanceDTO> ReturnTrainneeBySectionId(int sectionId)
        {
            return _employeeRepository.ReturnTrainneeBySectionId(sectionId);
        }
    }
}
