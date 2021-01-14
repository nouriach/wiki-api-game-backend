using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Web.Controllers
{
    public class PlayerController : Controller
    {
        List<Player> _players;

        public PlayerController()
        {
            _players = new List<Player>();
            for (int i = 0; i < 5; i++)
            {
                _players.Add(new Player { FullName = Guid.NewGuid().ToString() });
            }
        }
        [HttpGet("api/v1/players/{playerId}")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("api/v1/players")]
        public IActionResult GetAll()
        {
            return Ok(_players);
        }
    }
}
