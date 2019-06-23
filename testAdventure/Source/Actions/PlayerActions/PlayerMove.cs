using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class PlayerMove
    {
        static Directions Direction = new Directions();

        public static void Process(string direction)
        {
            if (ExitIsOpen(direction))
            {
                switch (direction)
                {
                    case "north":
                        AreaUtilities.Print_MoveToExit(direction);
                        Player.PosX--;
                        break;
                    case "south":
                        AreaUtilities.Print_MoveToExit(direction);
                        Player.PosX++;
                        break;
                    case "east":
                        AreaUtilities.Print_MoveToExit(direction);
                        Player.PosY--;
                        break;
                    case "west":
                        AreaUtilities.Print_MoveToExit(direction);
                        Player.PosY++;
                        break;
                }
                AreaUtilities.Print_AreaName();
                DynamicWordLists.Build();
            }
            else { AreaUtilities.Print_MoveToExit(direction); } 
        }

        public static bool ExitIsOpen(string cmd)
        {
            Exit exit = Player.Location().exitsList[Direction.Exit[cmd]];
            //DeBugging.Print(exit.name + ", " + exit.avaliable + ", " + exit.open + ", " + exit.direction);
            if (exit.open && exit.avaliable)
                return true;
            else return false;
        }

    }
}

        /*
            switch (direction)
            {
                case Direction.North:
                    Console.WriteLine("Move North");
                    Console.WriteLine("  From : " + "(" + Player.PosX + ", " + Player.PosY + ")");
                    Player.PosX--;
                    Console.WriteLine("  To   : " + "(" + Player.PosX + ", " + Player.PosY + ")");
                    break;
                case Direction.South:
                    Console.WriteLine("Move South");
                    Player.PosX++;
                    break;
                case Direction.East:
                    Console.WriteLine("Move East");
                    Player.PosX++;
                    break;
                case Direction.West:
                    Console.WriteLine("Move West");
                    Player.PosX--;
                    break;
            }
        */
       