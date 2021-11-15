using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class ContactUs
    {
        public int MessageId { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CreationDate { get; set; }

        public bool IsActive { get; set; }
    }
}
