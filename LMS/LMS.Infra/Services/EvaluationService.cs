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
    public class EvaluationService : IEvaluationService
    {
        private readonly IEvaluationRepository _evaluationRepository;

        public EvaluationService(IEvaluationRepository evaluationRepository)
        {
            _evaluationRepository = evaluationRepository;
        }

        public bool DeleteEvaluation(int evaluationId)
        {
            return _evaluationRepository.DeleteEvaluation(evaluationId);
        }

        public bool DeleteEvaluationAnswer(int evaluationAnswerId)
        {
            return _evaluationRepository.DeleteEvaluationAnswer(evaluationAnswerId);
        }

        public bool DeleteEvaluationQuestion(int evaluationQuestionId)
        {
            return _evaluationRepository.DeleteEvaluationQuestion(evaluationQuestionId);
        }

        public List<EvalouationAnswer> GetEvalouationQusetionAnswers(int evaluationquestionId, int querycode)
        {
            return _evaluationRepository.GetEvalouationQusetionAnswers (evaluationquestionId,querycode);
        }

        public bool InsertEvaluation(Evaluation evaluation)
        {
            return _evaluationRepository.InsertEvaluation(evaluation);  
        }

        public bool InsertEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            return _evaluationRepository.InsertEvaluationAnswer(evalouationAnswer);
        }

        public bool InsertEvaluationFormsAnswer(EvaluationFormsAnswer evaluationFormsAnswer)
        {
            return _evaluationRepository.InsertEvaluationFormsAnswer(evaluationFormsAnswer);
        }

        public bool InsertEvaluationFormsQuestion(EvaluationFormsQuestion evaluationFormsQuestion)
        {
            return _evaluationRepository.InsertEvaluationFormsQuestion(evaluationFormsQuestion);
        }

        public bool InsertEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            return _evaluationRepository.InsertEvaluationQuestion(evalouationQusetion);
        }

        /*public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForAllTrainee(int evaluationId)
        {
            return _evaluationRepository.ReturnEvaluationFormsAnswerForAllTrainee(evaluationId);
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForOneTrainee(int traineeId)
        {
            return _evaluationRepository.ReturnEvaluationFormsAnswerForOneTrainee(traineeId);
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsQuestion(int evaluationId)
        {
            return _evaluationRepository.ReturnEvaluationFormsQuestion(evaluationId);
        }
       
        public bool UpdateEvaluation(Evaluation evaluation)
        {
            return _evaluationRepository.UpdateEvaluation(evaluation);
        }
         */
        public bool UpdateEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            return _evaluationRepository.UpdateEvaluationAnswer(evalouationAnswer);
        }

        public bool UpdateEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            return _evaluationRepository.UpdateEvaluationQuestion(evalouationQusetion);
        }
    }
}
