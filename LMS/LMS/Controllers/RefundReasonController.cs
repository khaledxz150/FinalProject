using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefundReasonController : ControllerBase
    {
        private readonly IRefundReasonService refundReasonService;

        public RefundReasonController(IRefundReasonService refundReasonService)
        {
            this.refundReasonService = refundReasonService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<RefundReason> ReturnRefundReason(int queryCode)
        {
            return refundReasonService.ReturnRefundReason(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertRefundReason([FromBody] RefundReason refundReason)
        {
            return refundReasonService.InsertRefundReason(refundReason);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateRefundReason([FromBody] RefundReason refundReason)
        {
            return refundReasonService.UpdateRefundReason(refundReason);
        }

        [HttpDelete]
        [Route("[action]/{reasonId}")]
        public bool DeleteRefundReason(int reasonId)
        {
            return refundReasonService.DeleteRefundReason(reasonId);
        }
    }
}
