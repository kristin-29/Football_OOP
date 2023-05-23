using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<Football_player> Players { get; set; }
        public double Average_age
        {
            get
            {
                int allAges = 0;
                foreach (Football_player player in Players)
                {
                    allAges += player.Age;

                }
                return allAges / Players.Count;
            }
        }
        public Team(Coach coach, List<Football_player> players)
        {
            Coach = coach;
            Players = players;
        }
    }
}
