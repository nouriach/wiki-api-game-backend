using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Interfaces;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Services
{
    public class PlayerService : IPlayerService
    {
        public Task<Player> GetPlayerByIdAsync(int playerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Player>> GetPlayersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
