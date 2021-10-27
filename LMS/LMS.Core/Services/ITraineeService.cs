using LMS.Core.DTO;
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


    }
}
