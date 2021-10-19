using LMS.Core.Services;
using LMS.Data;
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
    public class LevelController : ControllerBase
    {
        private readonly ILevelService levelService;

        public LevelController(ILevelService levelService)
        {
            this.levelService = levelService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Level> ReturnLevel(int queryCode)
        {
            return levelService.ReturnLevel(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertLevel([FromBody] Level level)
        {
            return levelService.InsertLevel(level);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateLevel([FromBody] Level level)
        {
            return levelService.UpdateLevel(level);
        }

        [HttpDelete]
        [Route("[action]/{levelId}")]
        public bool DeleteLevel(int levelId)
        {
            return levelService.DeleteLevel(levelId);
        }
    }
}
