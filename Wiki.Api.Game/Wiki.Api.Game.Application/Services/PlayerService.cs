using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Interfaces;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly List<Player> _players;


        public PlayerService()
        {
            for (int i = 0; i < 5; i++)
            {
                _players.Add(new Player { FullName = Guid.NewGuid().ToString() });
            }
        }

        public async Task<Player> GetPlayerByIdAsync(int playerId)
        {
            var result = await _players.Where(x => x.Id == playerId).FirstOrDefault();
            return result;
        }

        public async Task< List<Player>> GetPlayersAsync()
        {
            var result = await _players;
            return result;
        }
    }
}
