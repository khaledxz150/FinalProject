using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? TraineeId { get; set; }
        public long? EmployeeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
