using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Interfaces;
using Wiki.Api.Game.Application.Services.Players.Commands.CommandQueries;

namespace Wiki.Api.Game.Application.Services.Players.Commands.CommandHandlers
{
    public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand, bool>
    {
        private readonly IPlayerService _playerService;

        public DeletePlayerCommandHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<bool> Handle(DeletePlayerCommand request, CancellationToken cancellationToken)
        {
            var result = await _playerService.DeletePlayerAsync(request.Id);
            return result;
        }
    }
}
