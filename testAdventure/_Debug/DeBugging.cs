using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class DeBugging
    {

        public static void TestArea()
        {
            print(Player.Location().areaName);
            print(Player.Location().areaLook);
            print(Player.Location().cinimatic.Count, "Cinematic");
            //print(Player.Location().cinimatic);
        }

        public static void print(string line)
        {
            Console.WriteLine(line + "\n");
        }

        public static void print(int num, string title)
        {
            Console.WriteLine(title + " Total Lines = " + num + "\n");
        }

        public static void print(List<string> list)
        {
            foreach (string line in list)
            {
                Console.WriteLine(line);
            }
        }

        public static void Pause(string text)
        {
            Console.CursorVisible = false;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*** DEBUG : " + text + ": DEBUG ***");
            UserInput.AnyKeyContinue();
        }

        public static void Pause()
        {
            string text = ("Press AnyKey to Continue");
            Console.CursorVisible = false;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*** DEBUG *** " + text + " *** DEBUG ***");
            UserInput.AnyKeyContinue();
        }
    }
}
