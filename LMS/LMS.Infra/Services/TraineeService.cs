using LMS.Core.DTO;
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
    public class TraineeService : ITraineeService
    {
        private readonly ITraineeRepository traineeRepository;

        public TraineeService(ITraineeRepository traineeRepository)
        {
            this.traineeRepository = traineeRepository;
        }
        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId)
        {
            return traineeRepository.ReturnTraineeAttendance(sectionId, lectureId);
        }

        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId)
        {
            return traineeRepository.ReturnTraineeInfo(traineeId);
        }

        public bool InsertTrainee(Trainee trainee)
        {
            return traineeRepository.InsertTrainee(trainee);    
        }

        //Update Trainee 
        public bool UpdateTrainee(Trainee trainee)
        {
            return traineeRepository.UpdateTrainee(trainee);
        }

        //Delete Trainee
        public bool DeleteTrainee(int traineeId)
        {
            return traineeRepository.DeleteTrainee(traineeId);  
        }
    }

}
