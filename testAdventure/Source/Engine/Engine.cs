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
            Level.InitiliseLevel();
            //CommandDictonary.InitialiseDefautls();
            Console.SetWindowSize(150, 40); // Default Size = 120 : 30
        }
    }
}
