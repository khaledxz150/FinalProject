using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class CourseRefundsService: ICourseRefundsService
    {
        private readonly ICourseRefundsRepository _courseRefundsRepository;

        public CourseRefundsService(ICourseRefundsRepository courseRefundsRepository)
        {
            _courseRefundsRepository = courseRefundsRepository;
        }

        public bool DeleteCourseRefunds(int courseRefundId)
        {
            return _courseRefundsRepository.DeleteCourseRefunds(courseRefundId);
        }

        public bool InsertCourseRefunds(CourseRefund courseRefund)
        {
            return _courseRefundsRepository.InsertCourseRefunds(courseRefund);  
        }

        public bool UpdateCourseRefunds(CourseRefund courseRefund)
        {
            return _courseRefundsRepository.UpdateCourseRefunds(courseRefund);
        }
    }
}
