using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Api.Game.Domain.Models;

namespace Wiki.Api.Game.Persistence.Data
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            JsonSerializer serialzier = new JsonSerializer();
            Player player;
            List<Player> players = new List<Player>();

            using (FileStream s = File.Open(@"C:\Users\NOURIACH\source\repos\Projects\wiki-api-game-backend\Wiki.Api.Game\Wiki.App.Game.Persistence\Data\footballerJson.json", FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        player = serialzier.Deserialize<Player>(reader);
                        players.Add(player);
                    }
                }
            }

            if (!context.Players.Any())
            {
                foreach (var result in players)
                {
                    context.Players.Add(
                        new Player()
                        {
                            FullName = result.FullName,
                            FirstPremierLeagueAppearance = result.FirstPremierLeagueAppearance,
                            LastPremierLeagueAppearance = result.LastPremierLeagueAppearance,
                            Clubs = result.Clubs,
                            Nationality = result.Nationality,
                            Position = result.Position,
                            TotalAppearances = result.TotalAppearances
                        });
                    context.SaveChanges();
                }
            }
        }
    }
}
