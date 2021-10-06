using LMS.Tahaluf.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Services
{
   public interface ISCTService
    {
        List<SCT> SCTs();
        public List<FUN_ALL_STD> FUN_ALL_STD();

    }
}
