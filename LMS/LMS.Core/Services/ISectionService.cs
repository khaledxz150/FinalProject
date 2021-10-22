using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface ISectionService
    {
        public List<Section> ReturnAllSection();
        public List<Section> AddSection(Section section);
        public List<Section> UpdateSection(Section section);
        public bool DeleteSection(int SectionId);


        public List<TraineeSection> AddTraineeSection(TraineeSection traineeSection);
        public bool DeleteTraineeSection(int traineeSectionId);
        public List<TraineeSection> ReturnTraineeSection();
        public List<TraineeSection> UpdateTraineeSection(TraineeSection traineeSection);




    }
}
