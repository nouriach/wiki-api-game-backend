using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wiki.Api.Game.Domain.Models
{
    public class Player
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string FullName { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("pos")]
        public string Position { get; set; }

        [JsonProperty("firstApp")]
        public int FirstPremierLeagueAppearance { get; set; }

        [JsonProperty("lastApp")]
        public int LastPremierLeagueAppearance { get; set; }

        [JsonProperty("totalApps")]
        public int TotalAppearances { get; set; }

        [JsonProperty("clubs")]
        public string Clubs { get; set; }

    }
}
