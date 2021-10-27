using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IRefundReasonService
    {
        public List<RefundReason> ReturnRefundReason(int queryCode);
        public bool InsertRefundReason(RefundReason refundReason);
        public bool UpdateRefundReason(RefundReason refundReason);
        public bool DeleteRefundReason(int reasonId);
    }
}
