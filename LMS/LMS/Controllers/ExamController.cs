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
    public class ExamController : ControllerBase
    {
        private readonly IExamService examService;

        public ExamController(IExamService examService)
        {
            this.examService = examService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Exam> ReturnExam(int queryCode)
        {
            return examService.ReturnExam(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertExam([FromBody] Exam exam)
        {
            return examService.InsertExam(exam);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateExam([FromBody] Exam exam)
        {
            return examService.UpdateExam(exam);
        }

        [HttpDelete]
        [Route("[action]/{examId}")]
        public bool DeleteExam(int examId)
        {
            return examService.DeleteExam(examId);
        }
    }
}
