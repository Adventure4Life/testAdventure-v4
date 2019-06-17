using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class Level
    {
        //Public Variable
        public static Area[,] GameWorld { get; set; } = new Area[3, 3];

        public static void InitiliseLevel()
        {
            DataReader ReadData = new DataReader();
            // Player Start
            GameWorld[Player.PosX, Player.PosY] = ReadData.ImportAreaData("(1,1)_testroom_startroom");
        }
    }
}

/*
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (0,0)       ║ ║ (0,1)       ║ ║ (0,2)       ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (1,0)       ║ ║ (1,1)       ║ ║ (1,2)       ║
║             ║ ║             ║ ║             ║
║             ║ ║ Player      ║ ║             ║
║             ║ ║ Start       ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (2,0)       ║ ║ (2,1)       ║ ║ (2,2)       ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
*/
