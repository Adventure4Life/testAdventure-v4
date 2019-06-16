using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class UserInput
    {
        public static void AnyKeyContinue()
        {
            Console.CursorVisible = false;
            Console.Write("\n\n");
            Pause_AnyKey();
            Console.CursorVisible = true;
        }

        public static void Pause_AnyKey()
        {
            do { } // do nothing in here.. just loop so it acts like a pause
            while (!Console.KeyAvailable); // when a key is pressed it breaks the loop
            ClearInput();
        }

        public static void ClearInput()
        {   //Loop through any inputs in the input buffer and "spend them" doing nothing.
            while (Console.KeyAvailable) { Console.ReadKey(true); }
        }
    }
}
