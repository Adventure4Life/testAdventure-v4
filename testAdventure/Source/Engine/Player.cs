using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class Player
    {
        // Variables : X,Y Position in Level Table (see Level)
        public static int PosX { get; set; }
        public static int PosY { get; set; }

        public static void Initilise()
        {
            PosX = 1;
            PosY = 1;
        }


        public static Area Location()
        {
            return Level.GameWorld[Player.PosX, Player.PosY];
        }
    }
}
