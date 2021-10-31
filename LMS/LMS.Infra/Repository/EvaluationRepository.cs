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
            parm.Add("@recordId", evaluationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteEvaluation", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteEvaluationAnswer(int evaluationAnswerId)
        {
            var parm = new DynamicParameters();
            parm.Add("@recordId", evaluationAnswerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteEvaluationAnswer", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteEvaluationQuestion(int evaluationQuestionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@recordId", evaluationQuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteEvaluationQuestion", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<EvalouationAnswer> GetEvalouationQusetionAnswers(int evaluationquestionId,int querycode)
        {
            
            var parm = new DynamicParameters();
            parm.Add("@Query_CODE", querycode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@QuestionId", evaluationquestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<EvalouationAnswer> result = _dbContext.Connection.Query<EvalouationAnswer>("ReturnEvaulationAnswer", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
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
