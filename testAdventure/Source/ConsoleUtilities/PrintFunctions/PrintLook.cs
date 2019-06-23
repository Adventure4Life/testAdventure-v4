using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class PrintLook
    {
        public void Print(object u)
        {
            //DeBugging.Print("Inside PRINTLOOK.PRINT");
            switch (u)
            {
                case string str:
                    printString((string)u);
                    break;
                case Area area:
                    printArea((Area)u);
                    break;
            }
        }

        public void printArea(Area u)
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(u.areaLook);
            PrintBuffer.PrintType("");
        }

        public void printString(string u)
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(u);
            PrintBuffer.PrintType("");
        }

        public void printArea()
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(Player.Location().areaLook);
            PrintBuffer.PrintType("");
        }

        public void AllExits()
        {
            List<Exit> exitList = Player.Location().exitsList;
            string north = "?";
            string south = "?";
            string east = "?";
            string west = "?";
            //string north, south, east, west;
            foreach (Exit exit in exitList)
            {
                switch (exit.direction)
                {
                    case "north":
                        north = exit.look;
                        break;
                    case "south":
                        south = exit.look;
                        break;
                    case "east":
                        east = exit.look;
                        break;
                    case "west":
                        west = exit.look;
                        break;
                }
            }
            List<string> build = new List<string>();
            build.Add("");
            build.Add("To Your North:");
            build.Add(north);
            build.Add("");
            build.Add("To Your South:");
            build.Add(south);
            build.Add("");
            build.Add("To Your East:");
            build.Add(east);
            build.Add("");
            build.Add("To Your West:");
            build.Add(west);

            FrameBuffer.ClearType();
            FrameBuffer.type = build;
            PrintBuffer.PrintType();

        }
    }
}
/********************************
 *       switch (u)
            {
                case string str:
                    pString(u);
                    break;
                case List<string> list:
                    pList((List<string>)u);
                    break;
                case Exit exit:
                    pExit(u);
                    break;
            }
        }
        private void pString(object unknown)
        {
            string command = (string)unknown;
            DeBugging.Print("STRING");
        }

        private void pList(object unknown)
        {
            DeBugging.Print("LIST");
        }

        private void pExit(object unknown)
        {
            DeBugging.Print("LIST");
        }*/


/*
         // Look @Exit (Direction)
        public void Print(Exit exit)
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(exit.look);
            PrintType();
        }

        //Look @Area
        public void Print()
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(Player.Location().areaLook);
            PrintType();
        }

        //Look @Direction
        public void Print(string direction)
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(Player.Location().areaLook);
            PrintType();
        }

        // Print
        private static void PrintType()
        {
            Console.WriteLine("");
            PrintBuffer.PrintType();
        }
*/
