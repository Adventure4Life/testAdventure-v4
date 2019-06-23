using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class AreaUtilities
    {
        public static void ActivateArea(Area area)
        {
            switch (Player.Location().hasBeenEntered)
            {
                case false:
                    {
                        Player.Location().setEntered(); // Set Bool Value so app knows we have been here before
                        FrameBuffer.ClearType();
                        FrameBuffer.type = area.cinimatic;
                        PrintBuffer.PrintType();
                        break;
                    }
                case true:
                    { break; }
            }
        }

        public static void Print_AreaName()
        {
            if (Player.Location().hasBeenEntered)
            {
                FrameBuffer.ClearType();
                FrameBuffer.SetType(Player.Location().areaName);
                PrintBuffer.PrintType();
            }
        }

        public static void Print_MoveToExit(string cmd)
        {
            Directions Direction = new Directions();
            Exit exit = Player.Location().exitsList[Direction.Exit[cmd]];

            if (!exit.used)
            {
                FrameBuffer.ClearType();
                FrameBuffer.AddLine_BlankType();
                FrameBuffer.SetType(exit.move);
                PrintBuffer.PrintType("");
                exit.used = true;
            }
            else //TODO Add Exit Data for walking to a exit (dataFile --Exit-USED:)
            {
                if (exit.avaliable)
                {
                    FrameBuffer.ClearType();
                    FrameBuffer.AddLine_BlankType();
                    FrameBuffer.SetType("You head " + TextUtils.FirstCharToUpper(cmd) + " again.");
                    PrintBuffer.PrintType();
                }
                else 
                {
                    FrameBuffer.ClearType();
                    FrameBuffer.AddLine_BlankType();
                    FrameBuffer.SetType(exit.move);
                    PrintBuffer.PrintType();
                }
            }

            if (PlayerMove.ExitIsOpen(cmd))
            {
                FrameBuffer.SetFrame("\n------------------------------------\n");
                PrintBuffer.PrintMoreFrame();
            }
        }
    }
}