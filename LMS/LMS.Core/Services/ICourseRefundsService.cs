using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface ICourseRefundsService
    {
        public bool InsertCourseRefunds(CourseRefund courseRefund);
        public bool UpdateCourseRefunds(CourseRefund courseRefund);
        public bool DeleteCourseRefunds(int courseRefundId);

        public List<RefundReason> ReturnRefundReason(int queryCode);
        public bool InsertRefundReason(RefundReason refundReason);
        public bool UpdateRefundReason(RefundReason refundReason);
        public bool DeleteRefundReason(int reasonId);
    }
}
