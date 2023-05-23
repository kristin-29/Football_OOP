using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AssistentReferee> AssistentReferees { get; set; }
        public List<Goal> Goal { get; set; }
        public string Game_result { get; set; }
        public Team Winner { get; set; }
    }
}
