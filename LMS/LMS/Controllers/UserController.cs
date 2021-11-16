using LMS.Core.DTO;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;

        }


        [HttpGet]
        [Route("[action]")]
        public List<Login> ReturnLogin()
        {
            return userService.ReturnLogin();
        }

        [HttpPost]
        [Route("[action]")]
        public bool Register([FromBody] Login login)
        {
            return userService.Register(login);
        }

        [HttpPut]
        [Route("[action]/{loginId}")]
        public bool DeleteLogin(int loginId)
        {
            return userService.DeleteLogin(loginId);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Authentiaction([FromBody] LoginDTO login)
        {

            var token = userService.Authentiaction(login);


            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);

            }
        }

    }

}
