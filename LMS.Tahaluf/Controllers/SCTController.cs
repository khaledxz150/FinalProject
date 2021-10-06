using LMS.Tahaluf.Core.DTO;
using LMS.Tahaluf.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Tahaluf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCTController : ControllerBase
    {
        private readonly ISCTService _SCTService;

        public SCTController(ISCTService sCTService)
        {
            _SCTService = sCTService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<SCT>), StatusCodes.Status200OK)]
        public List<SCT> SCTs()
        {
            return _SCTService.SCTs();
        }

        [HttpGet]
        [Route ("MarkInfo")]
        [ProducesResponseType(typeof(List<FUN_ALL_STD>), StatusCodes.Status200OK)]
        public List<FUN_ALL_STD> FUN_ALL_STD()
        {
            return _SCTService.FUN_ALL_STD();
        }
    }
}
