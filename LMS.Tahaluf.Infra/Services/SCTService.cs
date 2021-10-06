using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Repository;
using LMS.Tahaluf.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Infra.Services
{
    public class SCTService : ISCTService
    {
        private readonly ISCTRepository _SCTRepository;

        public SCTService(ISCTRepository sCTRepository)
        {
            _SCTRepository = sCTRepository;
        }

        public List<SCT> SCTs()
        {
            return _SCTRepository.SCTs();

        }
        public List<FUN_ALL_STD> FUN_ALL_STD()
        {
            return _SCTRepository.FUN_ALL_STD();
        }
    }
}
