using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.DTO
{
    public class TraineeInfoDTO
    {
        public int TraineeId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageName { get; set; }
        public string Nationality { get; set; }
        public int PhoneNumber { get; set; }
    }
}
