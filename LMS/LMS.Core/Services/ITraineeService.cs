using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface ITraineeService
    {
        //ReturnTraineeAttendance
        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId);

        //ReturnTraineeInfo
        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId);
        public bool InsertTrainee(Trainee trainee);

        //Update Trainee 
        public bool UpdateTrainee(Trainee trainee);

        //Delete Trainee
        public bool DeleteTrainee(int traineeId);

    }
}
