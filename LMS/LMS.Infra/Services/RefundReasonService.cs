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
    public class RefundReasonService: IRefundReasonService
    {
        private readonly IRefundReasonRepository refundReasonRepository;

        public RefundReasonService(IRefundReasonRepository refundReasonRepository)
        {
            this.refundReasonRepository = refundReasonRepository;
        }

        public bool DeleteRefundReason(int reasonId)
        {
            return refundReasonRepository.DeleteRefundReason(reasonId);
        }

        public bool InsertRefundReason(RefundReason refundReason)
        {
            return refundReasonRepository.InsertRefundReason(refundReason);
        }

        public List<RefundReason> ReturnRefundReason(int queryCode)
        {
            return refundReasonRepository.ReturnRefundReason(queryCode);
        }

        public bool UpdateRefundReason(RefundReason refundReason)
        {
            return refundReasonRepository.UpdateRefundReason(refundReason);
        }
    }
}
