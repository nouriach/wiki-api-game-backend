using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Services.Players.Queries
{
    public class GetAllPlayersQuery : IRequest<IEnumerable<Player>>
    {
    }
}
