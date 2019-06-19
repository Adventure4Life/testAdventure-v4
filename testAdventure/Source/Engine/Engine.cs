using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class Engine
    {
        public static void Initilise()
        {
            Player.Initilise();
            Level.Initilise();
            CommandDictonary.Initialise();
            Console.SetWindowSize(150, 40); // Default Size = 120 : 30
        }

        public static void StartScreen()
        {
            PrintBuffer.PrintFrame();
            PrintBuffer.PrintType();
            UserInput.AnyKeyContinue();
            PrintBuffer.PrintFrame();
        }

        public static void PlayGame()
        {
            AreaUtilities.ActivateArea(Player.Location());
            //Console.Write("\n> ");
            Console.Write("> ");
            UserInput.GetInput(Console.ReadLine());
        }

        public static void GoodByeScreen()
        {
            GoodByeScreen bye = new GoodByeScreen();
            FrameBuffer.frame = bye.GetFrame();
            FrameBuffer.type = bye.GetTypeWrite();
            PrintBuffer.PrintMoreFrame();
            PrintBuffer.PrintType();
            UserInput.Pause_AnyKey();
        }
    }
}
