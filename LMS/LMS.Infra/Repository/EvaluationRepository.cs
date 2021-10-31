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
            var parm = new DynamicParameters();
            parm.Add("@sectionId", evaluation.SectionId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@employeeId", evaluation.CreatedBy , dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("InsertEvaluation", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            var parm = new DynamicParameters();
            parm.Add("@employeeId", evalouationAnswer.CreatedBy , dbType: DbType.Int64, direction: ParameterDirection.Input);
            parm.Add("@questionId", evalouationAnswer.EvalouationQuestionId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@description",evalouationAnswer.Description , dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("InsertEvaluationAnswer", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertEvaluationFormsAnswer(EvaluationFormsAnswer evaluationFormsAnswer)
        {

            var parm = new DynamicParameters();
            parm.Add("@EvaluationId", evaluationFormsAnswer.EvaluationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@answerId", evaluationFormsAnswer.EvaluationAnswerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@traaineeId", evaluationFormsAnswer.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("InsertEvaluationFormsAnswer", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertEvaluationFormsQuestion(EvaluationFormsQuestion evaluationFormsQuestion)
        {
            var parm = new DynamicParameters();
            parm.Add("@EvaluationId", evaluationFormsQuestion.EvaluationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@questionId", evaluationFormsQuestion.QuestionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@employeeId", evaluationFormsQuestion.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("InsertEvaluationFormsQuestion", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            var parm = new DynamicParameters();
            parm.Add("@employeeId", evalouationQusetion.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);
            parm.Add("@description", evalouationQusetion.Descrition, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("InsertEvaluationQuestion", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        /*public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForAllTrainee(int evaluationId)
        {
            var parm = new DynamicParameters();

            parm.Add("", , dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<> result = _dbContext.Connection.Query<>("", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsAnswerForOneTrainee(int traineeId)
        {
            var parm = new DynamicParameters();
           
            parm.Add("", , dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<> result = _dbContext.Connection.Query<>("", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<EvaluationFormsQuestion> ReturnEvaluationFormsQuestion(int evaluationId)
        {
            var parm = new DynamicParameters();

            parm.Add("", , dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<> result = _dbContext.Connection.Query<>("", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }*/

        public bool UpdateEvaluationAnswer(EvalouationAnswer evalouationAnswer)
        {
            var parm = new DynamicParameters();
           
            parm.Add("@EvalouationAnswerId",evalouationAnswer.EvalouationAnswerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@Descrition", evalouationAnswer.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("UpdateEvaluationAnswer", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateEvaluationQuestion(EvalouationQusetion evalouationQusetion)
        {
            var parm = new DynamicParameters();
            parm.Add("@EvalouationQusetionId", evalouationQusetion.EvalouationQusetionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parm.Add("@Descrition", evalouationQusetion.Descrition, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("UpdateEvaluationQuestion", parm, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
