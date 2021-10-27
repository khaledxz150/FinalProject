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
    public class OffLineLectureService: IOffLineLectureService
    {
        private readonly IOffLineLectureRepository offLineLectureRepository;

        public OffLineLectureService(IOffLineLectureRepository offLineLectureRepository)
        {
            this.offLineLectureRepository = offLineLectureRepository;
        }

        public bool DeleteOffLineLecture(int offLineLectureId)
        {
            return offLineLectureRepository.DeleteOffLineLecture(offLineLectureId);
        }

        public bool InsertOffLineLecture(OffLineLecture offLineLecture)
        {
            return offLineLectureRepository.InsertOffLineLecture(offLineLecture);
        }

        public List<OffLineLecture> ReturnOffLineLecture(int queryCode)
        {
            return offLineLectureRepository.ReturnOffLineLecture(queryCode);

        }

        public bool UpdateOffLineLecture(OffLineLecture offLineLecture)
        {
            return offLineLectureRepository.UpdateOffLineLecture(offLineLecture);

        }
    }
}
