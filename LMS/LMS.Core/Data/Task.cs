﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Task
    {
        public Task()
        {
            TraineeSectionTasks = new HashSet<TraineeSectionTask>();
        }

        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public decimal Mark { get; set; }
        public string Note { get; set; }
        public decimal Weight { get; set; }
        public string FileUrl { get; set; }
        public DateTime Date { get; set; }
        public DateTime Deadline { get; set; }
        public int SectionTrainerId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual TrainerSection SectionTrainer { get; set; }
        public virtual ICollection<TraineeSectionTask> TraineeSectionTasks { get; set; }
    }
}