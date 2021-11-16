using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class EmployeeInfoDTO
    {
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string EmployeeImage { get; set; }
        public string PhoneNumber { get; set; }
        public double BasicSalary { get; set; }
        public string NationalSecurutiyNumber { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
