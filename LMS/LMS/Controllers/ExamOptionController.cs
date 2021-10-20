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
    public class ExamOptionController : ControllerBase
    {
        private readonly IExamOptionService examOptionService;

        public ExamOptionController(IExamOptionService examOptionService)
        {
            this.examOptionService = examOptionService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<ExamOption> ReturnExamOption(int queryCode)
        {
            return examOptionService.ReturnExamOption(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertExamOption([FromBody] ExamOption examOption)
        {
            return examOptionService.InsertExamOption(examOption);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateExamOption([FromBody] ExamOption examOption)
        {
            return examOptionService.UpdateExamOption(examOption);
        }

        [HttpDelete]
        [Route("[action]/{optionId}")]
        public bool DeleteExamOption(int optionId)
        {
            return examOptionService.DeleteExamOption(optionId);
        }
    }
}
