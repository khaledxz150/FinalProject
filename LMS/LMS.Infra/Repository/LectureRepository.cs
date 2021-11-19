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
    public class LectureRepository: ILectureRepository
    {
        private IDbContext dBContext;
        public LectureRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteLecture(int lectureId)
        {
            var parm = new DynamicParameters();
            parm.Add("@LectureId", lectureId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteLecture", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertLecture(Lecture lecture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@SectionId", lecture.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", lecture.CreatedBy, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertLecture", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Lecture> ReturnLecture(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Lecture> result = dBContext.Connection.Query<Lecture>("ReturnLecture", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Lecture> ReturnLectureBySectionId(int sectionId)
        {
            var parm = new DynamicParameters();
            parm.Add("@SectionId", sectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Lecture> result = dBContext.Connection.Query<Lecture>("ReturnLectureBySectionId", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateLecture(Lecture lecture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LectureId", lecture.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SectionId", lecture.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
          

            var result = dBContext.Connection.ExecuteAsync("UpdateLecture", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteOffLineLecture(int offLineLectureId)
        {
            var parm = new DynamicParameters();
            parm.Add("@OfflineLectureId", offLineLectureId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteOffLineLecture", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertOffLineLecture(OffLineLecture offLineLecture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CourseId", offLineLecture.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@VideoUrl", offLineLecture.VideoUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", offLineLecture.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CreatedBy", offLineLecture.CreatedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertOffLineLecture", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<OffLineLecture> ReturnOffLineLecture(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<OffLineLecture> result = dBContext.Connection.Query<OffLineLecture>("ReturnOffLineLecture", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateOffLineLecture(OffLineLecture offLineLecture)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@OfflineLectureId", offLineLecture.OfflineLectureId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@VideoUrl", offLineLecture.VideoUrl, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", offLineLecture.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@IsActive", offLineLecture.IsActive, dbType: DbType.Boolean, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateOffLineLecture", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
