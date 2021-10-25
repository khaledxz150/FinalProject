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
   public class ContactUsRepository: IContactUsRepository
    {
        private IDbContext dBContext;
        public ContactUsRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public bool DeleteMessage(int messageId)
        {
            var parm = new DynamicParameters();
            parm.Add("@MessageId", messageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteMessage", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool InsertMessage(ContactUs contactUs)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@TraineeId", contactUs.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Email", contactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@PhoneNumber", contactUs.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", contactUs.Description, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("InsertMessage", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ContactUs> ReturnMessage(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@P_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<ContactUs> result = dBContext.Connection.Query<ContactUs>("ReturnMessage", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateMessage(ContactUs contactUs)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@MessageId", contactUs.MessageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@TraineeId", contactUs.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Email", contactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@PhoneNumber", contactUs.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", contactUs.Description, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContext.Connection.ExecuteAsync("UpdateMessage", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }


        public Testimonial AddTestMonial(Testimonial testimonial) {
            var parameters = new DynamicParameters();
            parameters.Add("@P_Description", testimonial.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@P_CreatedBy", testimonial.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@P_isApproved", testimonial.IsApproved, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            parameters.Add("@P_ApprovedEmployeeId", testimonial.ApprovedEmployeeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Testimonial> result = dBContext.Connection.Query<Testimonial>("AddSection", commandType: CommandType.StoredProcedure);
            return ReturnAllTestMonial().OrderByDescending(x => x.TestimonialsId).FirstOrDefault();


        }

        public List<Testimonial> ReturnAllTestMonial() {
            IEnumerable<Testimonial> result = dBContext.Connection.Query<Testimonial>("AddSection", commandType: CommandType.StoredProcedure); return result.ToList();
        }


    }
}
