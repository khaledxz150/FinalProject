using LMS.Core.Data;
using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface IEmployeeRepository
    {
        // Employee
        public List<Employee> GetAllEmployess(int queryCode);
        public List<Employee> GetAllAttendance(int queryCode);
        public bool AddAttendanceTrainee(List<Attendance_Tup> att);

        public bool StatusEmployee(int empId);

        public Employee GetEmployee(Int64 employeeId);
        public List<TraineeAttendanceDTO> ReturnTrainneeBySectionId(int sectionId);
        public bool AddNewEmployee(EmployeeInfoDTO employee);
        public bool UpdateEmployee(Employee employee);
        public bool DeleteEmployee(Int64 employeeId);
        public bool DeleteEmployeeFromDatabase(long employeeId);
        public bool ChangeTrainerStatus(Int64 employeeId);

        //Role Type

        public bool AddRoleType(RoleType roleType);
        public bool DeleteRoleType(int roleTypeId);
        public List<RoleType> GetRoleTypes(int queryCode);



        //ReturnEmployeeInfo
        public List<EmployeeInfoDTO> ReturnEmployeeInfo(int employeeId);
    }
}
