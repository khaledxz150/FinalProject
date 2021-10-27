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
   public class LevelService: ILevelService
    {
        private readonly ILevelRepository levelRepository;

        public LevelService(ILevelRepository levelRepository)
        {
            this.levelRepository = levelRepository;
        }

        public bool DeleteLevel(int levelId)
        {
            return levelRepository.DeleteLevel(levelId);
        }

        public bool InsertLevel(Level level)
        {
            return levelRepository.InsertLevel(level);
        }

        public List<Level> ReturnLevel(int queryCode)
        {
            return levelRepository.ReturnLevel(queryCode);

        }

        public bool UpdateLevel(Level level)
        {
            return levelRepository.UpdateLevel(level);
        }
    }
}
