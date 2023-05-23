using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football_player player1 = new Goalkeeper("Ivan Ivanov", 15,  21, 190);
            Football_player player2 = new Defender("Petko Dimitrov", 6, 19, 183);
            Football_player player3 = new Midfield("Dimitar Stefanov", 20, 25, 176);
            Football_player player4 = new Striker("Georgi Stoqnov", 44, 17, 199);
            Football_player player5 = new Defender("Mihail Angelov", 8, 19, 188);
            Football_player player6 = new Defender("Daniel Mitev", 13, 22, 189);
            Football_player player7 = new Defender("Stefan Marinov", 7, 30, 173);
            Football_player player8 = new Striker("Aleksandar Petrov", 28, 25, 179);
            Football_player player9 = new Midfield("Borislav Nevenov", 4, 21, 187);
            Football_player player10 = new Midfield("Angel Svetlinov", 2, 26, 180);
            Football_player player11 = new Midfield("Kaloqn Ivelinov", 21, 19, 191);

            Coach coach = new Coach("Stanislav Dimov", 47);

            List<Football_player> players = new List<Football_player>
            { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11};
           

        }
    }
}
