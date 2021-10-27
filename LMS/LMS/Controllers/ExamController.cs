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

        [HttpPost]
        [Route("[action]")]
        public TraineeSectionExam AddTraineeSectionExam(TraineeSectionExam traineeSectionExam)
        {
            return examService.AddTraineeSectionExam(traineeSectionExam);
        }


        [HttpDelete]
        [Route("[action]/{examId}")]
        public bool DeleteTraineeSectionExam(int traineeSectionExamId) {

        return examService.DeleteTraineeSectionExam(traineeSectionExamId);

        }


        //ExamOption

        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<ExamOption> ReturnExamOption(int queryCode)
        {
            return examService.ReturnExamOption(queryCode);
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

        [HttpDelete]
        [Route("[action]/{optionId}")]
        public bool DeleteExamOption(int optionId)
        {
            return examService.DeleteExamOption(optionId);
        }

        //ExamQuestion

        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<ExamQuestion> ReturnExamQuestion(int queryCode)
        {
            return examService.ReturnExamQuestion(queryCode);
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

        [HttpDelete]
        [Route("[action]/{questionId}")]
        public bool DeleteExamQuestion(int questionId)
        {
            return examService.DeleteExamQuestion(questionId);
        }

        //ReturnExamBySectionId

        [HttpPost]
        [Route("[action]/{questionId}")]
        public List<Exam> ReturnExamBySectionId(int sectionId)
        {
            return examService.ReturnExamBySectionId(sectionId);
        }

    }
}
