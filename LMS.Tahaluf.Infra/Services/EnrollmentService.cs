using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepositiory _enrollment;

        public EnrollmentService(IEnrollmentRepositiory repositiory)
        {
            _enrollment = repositiory;  
        }

        public List<Enrollment> getAllEnrolmentsRecord()
        {
            return _enrollment.getAllEnrolmentsRecord();
        }
    }
}
