using LMS.Core.Data;
using LMS.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{       [Route("api/chat")]
        [ApiController]
    public class ChatController : Controller
    {

        private readonly IHubContext<ChatHub> _hubContext;

        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("send")]                                           //path looks like this: https://localhost:44379/api/chat/send
        [HttpPost]  
        public IActionResult SendRequest([FromBody] Message msg)
        {
            _hubContext.Clients.All.SendAsync("ReceiveOne", msg);
            return Ok();
        }
    }
}

