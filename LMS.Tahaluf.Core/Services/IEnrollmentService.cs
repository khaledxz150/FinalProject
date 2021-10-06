using LMS.Tahaluf.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
    public interface IEnrollmentService
    {
        public List<Enrollment> getAllEnrolmentsRecord();
    }
}
