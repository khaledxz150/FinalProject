using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class TraineeSectionTask
    {
        public int TraineeSectionTaskId { get; set; }
        public int TraineeSectionId { get; set; }
        public int TaskId { get; set; }
        public string Note { get; set; }
        public string FileUrl { get; set; }
        public decimal? Mark { get; set; }
        public string TrainerNote { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
    

        public virtual Tasks Task { get; set; }
        public virtual TraineeSection TraineeSection { get; set; }
    }
}
