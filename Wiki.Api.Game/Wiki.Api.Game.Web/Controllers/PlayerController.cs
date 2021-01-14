using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wiki.Api.Game.Web.Controllers
{
    public class PlayerController : Controller
    {
        
        public PlayerController()
        {

        }
        [HttpGet("api/v1/players/{playerId}")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("api/v1/players")]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
