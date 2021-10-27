using LMS.Core.DTO;
using LMS.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeService traineeService;

        public TraineeController(ITraineeService traineeService)
        {
            this.traineeService = traineeService;
        }


        //ReturnTraineeAttendance

        [HttpPost]
        [Route("[action]/{sectionId}/{lectureId}")]
        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId)
        {
            return traineeService.ReturnTraineeAttendance(sectionId, lectureId);
        }


        //ReturnTraineeInfo
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId)
        {
            return traineeService.ReturnTraineeInfo(traineeId);
        }




    }
}
