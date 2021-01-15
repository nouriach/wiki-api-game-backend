using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Contracts;
using Wiki.Api.Game.Application.Services.Players.Commands.CommandQueries;
using Wiki.Api.Game.Application.Services.Players.Queries;

namespace Wiki.Api.Game.Web.Controllers
{
    public class PlayerController : Controller
    {
        IMediator _mediator;

        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRoutes.Players.Get)]
        public async Task <IActionResult> Get(int playerId)
        {

            var result = await _mediator.Send(new GetPlayerQuery { Id = playerId });

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet(ApiRoutes.Players.GetAll)]
        public async Task<IActionResult> GetAll(GetAllPlayersQuery query)
        {
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete(ApiRoutes.Players.Delete)]

        public async Task<IActionResult> Delete([FromRoute] int playerId)
        {
            var result = await _mediator.Send( new DeletePlayerCommand { Id = playerId });

            if (result)
                return Content($"Player with Id {playerId} has been deleted");
            else
                return NotFound();
        }
    }
}
