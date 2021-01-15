using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerByIdAsync(int playerId);
        Task<List<Player>> GetPlayersAsync();
        Task<bool> DeletePlayerAsync(int playerId);

    }
}
