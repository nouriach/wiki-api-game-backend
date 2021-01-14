using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Services.Players.Queries;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Services.Players.Handlers
{
    public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, Player>
    {
        public Task<Player> Handle(GetAllPlayersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
