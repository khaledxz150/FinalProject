using System;
using System.Collections.Generic;

#nullable disable

namespace LMS.Data
{
    public partial class ErrorLog
    {
        public long Id { get; set; }
        public string ErrorProcedure { get; set; }
        public string ErrorLine { get; set; }
        public string ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorSeverity { get; set; }
        public string ErrorState { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
