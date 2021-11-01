﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Level
    {

        public int LevelId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
