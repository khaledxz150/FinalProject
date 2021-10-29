using Dapper;
using First.Core.Common;
using LMS.Core.Repository;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Repository
{
    public class EvaluationRepository : IEvaluationRepository
    {
        private readonly IDbContext _dbContext;
        public EvaluationRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool DeleteEvaluation(int evaluationId)
        {
            //define Parameter
            //now
            var parm = new DynamicParameters();
            parm.Add("", evaluationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteEvaluationAnswer(int evaluationAnswerId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEvaluationQuestion(int evaluationQuestionId)
        {
            throw new NotImplementedException();
        }

        public List<EvalouationAnswer> GetEvalouationQusetionAnswers(int evaluationquestionId)
        {
            throw new NotImplementedException();
        }

        public bool InsertEvaluation(Evaluation evaluation)
        {
            throw new NotImplementedException();
        }

        public bool InsertEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            throw new NotImplementedException();
        }

        public bool InsertEvaluationFormsAnswer(EvaluationFormsAnswer evaluationFormsAnswer)
        {
            throw new NotImplementedException();
        }

        public bool InsertEvaluationFormsQuestion(EvaluationFormsQuestion evaluationFormsQuestion)
        {
            throw new NotImplementedException();
        }

        public bool InsertEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            throw new NotImplementedException();
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForAllTrainee(int evaluationId)
        {
            throw new NotImplementedException();
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForOneTrainee(int traineeId)
        {
            throw new NotImplementedException();
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsQuestion(int evaluationId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvaluation(Evaluation evaluation)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            throw new NotImplementedException();
        }
    }
}
