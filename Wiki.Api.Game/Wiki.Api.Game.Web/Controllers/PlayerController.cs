using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Contracts;
using Wiki.Api.Game.Application.Interfaces;
using Wiki.Api.Game.Application.Services;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Web.Controllers
{
    public class PlayerController : Controller
    {
        IPlayerService _playerService;

        public PlayerController()
        {
            _playerService = new PlayerService();
        }
        [HttpGet(ApiRoutes.Players.Get)]
        public IActionResult Get(Guid playerId)
        {
            var result = _playerService.GetPlayerByIdAsync(playerId);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet(ApiRoutes.Players.GetAll)]
        public IActionResult GetAll()
        {
            var result = _playerService.GetPlayersAsync();
            return Ok(result);
        }
    }
}
