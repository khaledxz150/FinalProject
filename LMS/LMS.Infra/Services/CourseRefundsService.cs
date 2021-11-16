using LMS.Core.DTO;
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
        public List<CourseRefundDTO> ReturnCourseRefund(int traineeId)
        {
            return _courseRefundsRepository.ReturnCourseRefund(traineeId);
        }
        public bool DeleteRefundReason(int reasonId)
        {
            return _courseRefundsRepository.DeleteRefundReason(reasonId);
        }

        public bool InsertRefundReason(RefundReason refundReason)
        {
            return _courseRefundsRepository.InsertRefundReason(refundReason);
        }

        public List<RefundReason> ReturnRefundReason(int queryCode)
        {
            return _courseRefundsRepository.ReturnRefundReason(queryCode);
        }

        public bool UpdateRefundReason(RefundReason refundReason)
        {
            return _courseRefundsRepository.UpdateRefundReason(refundReason);
        }

        public bool ApproveRefundReason(int CourseRefundsId)
        {
            return _courseRefundsRepository.ApproveRefundReason(CourseRefundsId);
        }
    }
}
