using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationController : ControllerBase
    {

        private readonly IEvaluationService _evaluationService;


        public EvaluationController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        // Evaluation 
        [HttpPost]
        [Route("[action]")]
        public bool InsertEvaluation(Evaluation evaluation)
        {
             return _evaluationService.InsertEvaluation(evaluation);
        }
        /*
        [HttpPost]
        [Route("[action]")]
        public bool UpdateEvaluation(Evaluation evaluation)
        {
            return _evaluationService.UpdateEvaluation(evaluation);
        }*/
        [HttpPut]
        [Route("[action]/{evaluationId}")]
        public bool DeleteEvaluation(int evaluationId)
        {

            return _evaluationService.DeleteEvaluation(evaluationId);   
        }

        //Evaluation Question 
        [HttpPost]
        [Route("[action]")]
        public bool InsertEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            return _evaluationService.InsertEvaluationQuestion(evalouationQusetion);
        }
        [HttpPost]
        [Route("[action]")]
        public bool UpdateEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            return _evaluationService.UpdateEvaluationQuestion(evalouationQusetion);
        }
        [HttpPut]
        [Route("[action]/{evaluationQuestionId}")]
        public bool DeleteEvaluationQuestion(int evaluationQuestionId)
        {
            return _evaluationService.DeleteEvaluationQuestion(evaluationQuestionId);
        }

        //Evaluation Answer
        [HttpPost]
        [Route("[action]")]
        public bool InsertEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            return _evaluationService.InsertEvaluationAnswer(evalouationAnswer);
        }
        [HttpPost]
        [Route("[action]")]
        public bool UpdateEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            return _evaluationService.UpdateEvaluationAnswer(evalouationAnswer);
        }
        [HttpPut]
        [Route("[action]/{evaluationAnswerId}")]
        public bool DeleteEvaluationAnswer(int evaluationAnswerId)
        {
            return _evaluationService.DeleteEvaluationAnswer(evaluationAnswerId);
        }
        [HttpGet]
        [Route("[action]/{evaluationquestionId}/{querycode}")]
        public List<EvalouationAnswer> GetEvalouationQusetionAnswers(int evaluationquestionId, int querycode)
        {
            return _evaluationService.GetEvalouationQusetionAnswers(evaluationquestionId,querycode);
        }
        [HttpPost]
        [Route("[action]")]
        //EvaluationFormsQuestion
        public bool InsertEvaluationFormsQuestion(EvaluationFormsQuestion evaluationFormsQuestion)
        {
            return _evaluationService.InsertEvaluationFormsQuestion(evaluationFormsQuestion);
        }
         /*
        [HttpGet]
        [Route("[action]/{evaluationId}")]
        public List<EvaluationFormsQuestion> ReturnEvaluationFormsQuestion(int evaluationId)
        {
            return _evaluationService.ReturnEvaluationFormsQuestion(evaluationId);
        }

        //EvaluationFormsAnswer
        [HttpPost]
        [Route("[action]")]
        public bool InsertEvaluationFormsAnswer(EvaluationFormsAnswer evaluationFormsAnswer)
        {
            return _evaluationService.InsertEvaluationFormsAnswer (evaluationFormsAnswer);
        }
        [HttpGet]
        [Route("[action]/{evaluationId}")]
        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForAllTrainee(int evaluationId)
        {
            return _evaluationService.ReturnEvaluationFormsAnswerForAllTrainee(evaluationId);
        }
        [HttpGet]
        [Route("[action]/{traineeId}")]
        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForOneTrainee(int traineeId)
        {
            return _evaluationService.ReturnEvaluationFormsAnswerForOneTrainee(traineeId);
        }
          */
       // test changes 54
    }
}
