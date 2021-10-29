using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface ITraineeRepository
    {

        //ReturnTraineeAttendance
        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId);

        //ReturnTraineeInfo
        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId);

        // Add New Trainee 
        public bool InsertTrainee(Trainee trainee);

        //Update Trainee 
        public bool UpdateTrainee(Trainee trainee);

        //Delete Trainee
        public bool DeleteTrainee(int traineeId);




    }
}
