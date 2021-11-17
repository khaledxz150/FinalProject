using LMS.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;

namespace LMS.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            // Clients must have an eventhandler for ReceiveMessage
            return Clients.All.SendAsync("ReceiveOne", user, message);
        }
    }
}
