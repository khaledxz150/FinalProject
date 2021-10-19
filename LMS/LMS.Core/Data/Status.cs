using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
