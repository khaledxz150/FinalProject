using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public bool InsertEvaluation(Evaluation evaluation)
        {
             return _evaluationService.InsertEvaluation(evaluation);
        }
        public bool UpdateEvaluation(Evaluation evaluation)
        {
            return _evaluationService.UpdateEvaluation(evaluation);
        }
        public bool DeleteEvaluation(int evaluationId)
        {

            return _evaluationService.DeleteEvaluation(evaluationId);   
        }

        //Evaluation Question 
        public bool InsertEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            return _evaluationService.InsertEvaluationQuestion(evalouationQusetion);
        }
        public bool UpdateEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            return _evaluationService.UpdateEvaluationQuestion(evalouationQusetion);
        }

        public bool DeleteEvaluationQuestion(int evaluationQuestionId)
        {
            return _evaluationService.DeleteEvaluationQuestion(evaluationQuestionId);
        }

        //Evaluation Answer
        public bool InsertEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            return _evaluationService.InsertEvaluationAnswer(evalouationAnswer);
        }
        public bool UpdateEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            return _evaluationService.UpdateEvaluationAnswer(evalouationAnswer);
        }

        public bool DeleteEvaluationAnswer(int evaluationAnswerId)
        {
            return _evaluationService.DeleteEvaluationAnswer(evaluationAnswerId);
        }

        public List<EvalouationAnswer> GetEvalouationQusetionAnswers(int evaluationquestionId)
        {
            return _evaluationService.GetEvalouationQusetionAnswers(evaluationquestionId);
        }

        //EvaluationFormsQuestion
        public bool InsertEvaluationFormsQuestion(EvaluationFormsQuestion evaluationFormsQuestion)
        {
            return _evaluationService.InsertEvaluationFormsQuestion(evaluationFormsQuestion);
        }
        public List<EvaluationFormsQuestion> ReturnEvaluationFormsQuestion(int evaluationId)
        {
            return _evaluationService.ReturnEvaluationFormsQuestion(evaluationId);
        }

        //EvaluationFormsAnswer
        public bool InsertEvaluationFormsAnswer(EvaluationFormsAnswer evaluationFormsAnswer)
        {
            return _evaluationService.InsertEvaluationFormsAnswer (evaluationFormsAnswer);
        }
        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForAllTrainee(int evaluationId)
        {
            return _evaluationService.ReturnEvaluationFormsAnswerForAllTrainee(evaluationId);
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForOneTrainee(int traineeId)
        {
            return _evaluationService.ReturnEvaluationFormsAnswerForOneTrainee(traineeId);
        }
    }
}
