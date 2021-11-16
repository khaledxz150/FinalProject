using LMS.Core.Data;
using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IEmployeeService
    {
        public List<Employee> GetAllEmployess(int queryCode);

        public Employee GetEmployee(Int64 employeeId);
        public bool AddAttendanceTrainee(List<Attendance_Tup> att);
        public Task<bool> AddNewEmployee(EmployeeInfoDTO employee);
        public bool UpdateEmployee(Employee employee);
        public bool DeleteEmployee(Int64 employeeId);
        //Role Type

        public bool AddRoleType(RoleType roleType);
        public bool DeleteRoleType(int roleTypeId);
        public List<RoleType> GetRoleTypes(int queryCode);

        public bool ChangeTrainerStatus(long employeeId);
        
        //ReturnEmployeeInfo
        public List<EmployeeInfoDTO> ReturnEmployeeInfo(int employeeId);
        public bool DeleteEmployeeFromDatabase(long employeeId);

   
        public List<TraineeAttendanceDTO> ReturnTrainneeBySectionId(int sectionId);
    }
}
