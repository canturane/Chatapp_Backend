﻿using Microsoft.AspNetCore.Mvc;



namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController:Controller
    {
        [HttpGet]
        public string Get()
        {
            return "hello";
        }
    }
}
