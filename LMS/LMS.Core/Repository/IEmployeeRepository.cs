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
        public List<Employee> GetAllEmployess(int queryCode);

        public Employee GetEmployee(Int64 employeeId);
        public bool AddNewEmployee(Employee employee);
        public bool UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(Int64 employeeId);
    }
}
