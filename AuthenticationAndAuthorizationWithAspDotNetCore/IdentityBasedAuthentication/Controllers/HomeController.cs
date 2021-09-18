﻿using Microsoft.AspNetCore.Mvc;

namespace IdentityBasedAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Index");
        }
    }
}
