﻿using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
   public interface ILevelService
    {
        public List<Level> ReturnLevel(int queryCode);
        public bool InsertLevel(Level level);
        public bool UpdateLevel(Level level);
        public bool DeleteLevel(int levelId);
    }
}