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
        private readonly List<Player> _players;

        public PlayerService()
        {
            _players = new List<Player>();
            for (int i = 0; i < 5; i++)
            {
                _players.Add(new Player { FullName = Guid.NewGuid().ToString() });
            }
        }

        public Player GetPlayerByIdAsync(Guid playerId)
        {
            var result = _players.Find(p => p.FullName == playerId.ToString());
            return result;
        }

        public List<Player> GetPlayersAsync()
        {
            return _players;
        }
    }
}
