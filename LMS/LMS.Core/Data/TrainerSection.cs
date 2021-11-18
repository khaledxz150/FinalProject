using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class TrainerSection
    {


        public int Id { get; set; }
        public long TrainerId { get; set; }
        public int SectionId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long? CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Employee Trainer { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
