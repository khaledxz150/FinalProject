using LMS.Core.Data;
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
        [Route("[action]")]
        public List<Exam> ReturnExam([FromQuery] int queryCode, [FromQuery] int sectionId)
        {
            return examService.ReturnExam(queryCode, sectionId);
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

        [HttpPost]
        [Route("[action]")]
        public bool AddTraineeSectionExam([FromBody]TraineeSectionExam traineeSectionExam)
        {
            return examService.AddTraineeSectionExam(traineeSectionExam);
        }





        //ExamOption

        [HttpPost]
        [Route("[action]")]
        public List<ExamOption> ReturnExamOption([FromQuery]int queryCode, [FromQuery] int questionId)
        {
            return examService.ReturnExamOption(queryCode,questionId);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertExamOption([FromBody] ExamOption examOption)
        {
            return examService.InsertExamOption(examOption);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateExamOption([FromBody] ExamOption examOption)
        {
            return examService.UpdateExamOption(examOption);
        }

        [HttpPut]
        [Route("[action]/{optionId}")]
        public bool DeleteExamOption(int optionId)
        {
            return examService.DeleteExamOption(optionId);
        }

        //ExamQuestion

        [HttpPost]
        [Route("[action]")]
        public List<ExamQuestion> ReturnExamQuestion([FromQuery] int queryCode, [FromQuery] int courseId)
        {
            return examService.ReturnExamQuestion(queryCode,courseId);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertExamQuestion([FromBody] ExamQuestion examQuestion)
        {
            return examService.InsertExamQuestion(examQuestion);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateExamQuestion([FromBody] ExamQuestion examQuestion)
        {
            return examService.UpdateExamQuestion(examQuestion);
        }

        [HttpPut]
        [Route("[action]/{questionId}")]
        public bool DeleteExamQuestion(int questionId)
        {
            return examService.DeleteExamQuestion(questionId);
        }

        //ReturnExamBySectionId

        [HttpPost]
        [Route("[action]/{sectionId}")]
        public List<Exam> ReturnExamBySectionId(int sectionId)
        {
            return examService.ReturnExamBySectionId(sectionId);
        }


        [HttpDelete]
        [Route("[action]/{examQuestionAnswerId}")]
        public bool DeleteExamQuestionAnswer(int examQuestionAnswerId)
        {
            return examService.DeleteExamQuestionAnswer(examQuestionAnswerId);
        }


        [HttpPost]
        [Route("[action]")]
        public bool InsertExamQuestionAnswer(ExamQuestionAnswer examQuestionAnswer)
        {
            return examService.InsertExamQuestionAnswer(examQuestionAnswer);
        }


        [HttpPost]
        [Route("[action]/{examId}")]
        public List<ExamQuestionAnswer> ReturnExamQuestionAnswer(int examId)
        {
            return examService.ReturnExamQuestionAnswer(examId);
        }

    }
}
