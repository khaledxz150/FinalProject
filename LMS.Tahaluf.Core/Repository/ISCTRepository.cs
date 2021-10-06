using LMS.Tahaluf.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Tahaluf.Core.Repository
{
   public interface ISCTRepository
    {
        List<SCT> SCTs();
        public List<FUN_ALL_STD> FUN_ALL_STD();

    }
}
