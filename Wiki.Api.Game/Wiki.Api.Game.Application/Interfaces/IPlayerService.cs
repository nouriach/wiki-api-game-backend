using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Interfaces
{
    public interface IPlayerService
    {
        Player GetPlayerByIdAsync(Guid playerId);
        List<Player> GetPlayersAsync();

    }
}
