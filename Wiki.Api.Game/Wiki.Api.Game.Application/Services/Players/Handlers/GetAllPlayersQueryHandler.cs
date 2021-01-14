using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Interfaces;
using Wiki.Api.Game.Application.Services.Players.Queries;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Services.Players.Handlers
{
    public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, IEnumerable<Player>>
    {
        private readonly IPlayerService _playerService;

        public GetAllPlayersQueryHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<IEnumerable<Player>> Handle(GetAllPlayersQuery request, CancellationToken cancellationToken)
        {
            var result = await _playerService.GetPlayersAsync();
            return result;
        }
    }
}
