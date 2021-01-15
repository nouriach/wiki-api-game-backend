using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.Api.Game.Application.Services.Players.Commands.CommandQueries
{
    public class DeletePlayerCommand : IRequest<bool>
    {
        public int Id { get; set; }

    }
}
