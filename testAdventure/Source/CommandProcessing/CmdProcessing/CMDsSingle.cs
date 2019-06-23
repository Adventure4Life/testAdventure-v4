using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class CMDsSingle
    {
        private static bool doOther = true;

        public static void Process(string cmd)
        {
            doOther = true;
            FrameBuffer.ClearType();
            cmd = MatchSynonym.ToSinglesCommands(cmd);
            ProcessMove(cmd);
            //DeBugging.Print(cmd);
            if (doOther)
                ProcessOther(cmd);
        }

        public static void ProcessMove(string cmd)
        {
            switch (cmd)
            {
                case "north":
                    //Console.WriteLine("\nProcess : " + cmd);
                    Player.Move(cmd);
                    doOther = false;
                    break;
                case "south":
                    //Console.WriteLine("\nProcess : " + cmd);
                    Player.Move(cmd);
                    doOther = false;
                    break;
                case "east":
                    //Console.WriteLine("\nProcess : " + cmd);
                    Player.Move(cmd);
                    doOther = false;
                    break;
                case "west":
                    //Console.WriteLine("\nProcess : " + cmd);
                    Player.Move(cmd);
                    doOther = false;
                    break;
            }
        }

        public static void ProcessOther(string cmd)
        {
            switch (cmd)
            {
                case "look":
                    //Console.WriteLine("\nProcess : " + cmd);
                    LookAt();
                    break;
                case "inventori":
                    Console.WriteLine("\nProcess : " + cmd);
                    break;
                case "map":
                    Console.WriteLine("\nProcess : " + cmd);
                    break;
                case "exitgam":
                    GameState.QuitGame();
                    break;
            }
        }

        private static void LookAt()
        {
            PrintLook Look = new PrintLook();
            Look.printArea();
        }
    }
}
