using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class RoleType
    {
        public RoleType()
        {
            Employees = new HashSet<Employee>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
