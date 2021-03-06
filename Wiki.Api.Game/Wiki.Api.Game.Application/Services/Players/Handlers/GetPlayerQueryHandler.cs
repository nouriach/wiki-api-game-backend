﻿using MediatR;
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
    public class GetPlayerQueryHandler : IRequestHandler<GetPlayerQuery, Player>
    {
        private readonly IPlayerService _playerService;

        public GetPlayerQueryHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<Player> Handle(GetPlayerQuery request, CancellationToken cancellationToken)
        {
            var result = await _playerService.GetPlayerByIdAsync(request.Id);
            return result;
        }
    }
}
