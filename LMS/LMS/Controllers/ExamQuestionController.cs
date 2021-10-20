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
    public class ExamQuestionController : ControllerBase
    {
        private readonly IExamQuestionService examQuestionService;

        public ExamQuestionController(IExamQuestionService examQuestionService)
        {
            this.examQuestionService = examQuestionService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<ExamQuestion> ReturnExamQuestion(int queryCode)
        {
            return examQuestionService.ReturnExamQuestion(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertExamQuestion([FromBody] ExamQuestion examQuestion)
        {
            return examQuestionService.InsertExamQuestion(examQuestion);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateExamQuestion([FromBody] ExamQuestion examQuestion)
        {
            return examQuestionService.UpdateExamQuestion(examQuestion);
        }

        [HttpDelete]
        [Route("[action]/{questionId}")]
        public bool DeleteExamQuestion(int questionId)
        {
            return examQuestionService.DeleteExamQuestion(questionId);
        }
    }
}
