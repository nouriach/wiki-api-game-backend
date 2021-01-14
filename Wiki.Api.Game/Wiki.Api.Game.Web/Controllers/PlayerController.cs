using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Contracts;
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
        [HttpGet(ApiRoutes.Players.Get)]
        public IActionResult Get(Guid playerId)
        {
            var result = _players.Where(x => x.FullName.Contains(playerId.ToString())).SingleOrDefault();
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet(ApiRoutes.Players.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_players);
        }
    }
}
