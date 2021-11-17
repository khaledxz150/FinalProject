using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class Unit
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string FilePath { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }
        public string Title { get; set; }
        public string FileType { get; set; }


        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Section Section { get; set; }
    }
}
