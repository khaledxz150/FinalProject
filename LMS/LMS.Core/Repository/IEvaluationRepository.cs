using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface IEvaluationRepository
    {
        // Evaluation 
        public bool InsertEvaluation(Evaluation evaluation);
        public bool DeleteEvaluation(int evaluationId);

        //Evaluation Question 
        public bool InsertEvaluationQuestion(EvalouationQusetion evalouationQusetion);
        public bool UpdateEvaluationQuestion(EvalouationQusetion evalouationQusetion);

        public bool DeleteEvaluationQuestion(int evaluationQuestionId);

        //Evaluation Answer
        public bool InsertEvaluationAnswer(EvalouationAnswer evalouationAnswer);
        public bool UpdateEvaluationAnswer(EvalouationAnswer evalouationAnswer);

        public bool DeleteEvaluationAnswer(int evaluationAnswerId);

        public List<EvalouationAnswer> GetEvalouationQusetionAnswers(int evaluationquestionId,int querycode);

        //EvaluationFormsQuestion
        public bool InsertEvaluationFormsQuestion(EvaluationFormsQuestion evaluationFormsQuestion);
        //public List<EvaluationFormsQuestion> ReturnEvaluationFormsQuestion(int evaluationId);

        //EvaluationFormsAnswer
        public bool InsertEvaluationFormsAnswer(EvaluationFormsAnswer evaluationFormsAnswer);
        //public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForAllTrainee(int evaluationId);

        //public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForOneTrainee(int traineeId);
    }
}
