using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Api.Game.Application.Interfaces;
using Wiki.Api.Game.Domain.Models;
using Wiki.Api.Game.Persistence.Data;

namespace Wiki.Api.Game.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeletePlayerAsync(int playerId)
        {
            var playerToDelete = await GetPlayerByIdAsync(playerId);
            if (playerToDelete == null)
                return false;

            _context.Players.Remove(playerToDelete);
            _context.SaveChanges();

            return true;
        }

        public async Task<Player> GetPlayerByIdAsync(int playerId)
        {
            var player = await _context.Players.Where(p => p.Id == playerId).SingleOrDefaultAsync();
            return player;
            
        }

        public async Task <List<Player>> GetPlayersAsync()
        {
            
            return await _context.Players.ToListAsync();
        }
    }
}
