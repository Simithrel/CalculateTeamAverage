using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStatsAveraging
{
    class PlayerStats
    {
        public string Username { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int Damage { get; set; }

        public PlayerStats (string username, int kills, int deaths, int assists, int damage)
        {
            Username = username;
            Kills = kills;
            Deaths = deaths;
            Assists = assists;
            Damage = damage;
        }

        public override string ToString()
        {
            return $"{Username} {Kills}/{Deaths}/{Assists}/{Damage}";
        }
    }
}