﻿using ChatApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HubController : Controller
    {
        private readonly ISignalrConnection _signalrConnection;

        public HubController(ISignalrConnection signalrConnection)
        {
            _signalrConnection = signalrConnection;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string message)
        {
            var connect = _signalrConnection.StartConnection();
            await connect.InvokeAsync("SendMessageToAll", "Admin", message);
            return Ok();
        }
    }
}
