using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class testAdventure
    {
        static void Main(string[] args)
        {
            Engine.Initilise();
            //Engine.StartScreen();

            while (GameState.GameHasNotEnded())
            {
                Engine.PlayGame();
            }

            Engine.GoodByeScreen();
        }
    }
}
