using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class DeBugging
    {

        public static void TestExitsInArea()
        {
            foreach (Exit exit in Player.Location().exitsList)
            {
                Print(exit.name);
                Print(exit.direction);
                Print(exit.avaliable);
                Print(exit.open);
                Print(exit.look);
                Print(exit.move);
            }
        }


        public static void TestItemsInArea()
        {
            foreach (Item item in Player.Location().itemsList)
            {
                Print(item.name);
                Print(item.AllowGet);
                Print(item.lookText);
                Print(item.getText);
                Print(item.LoadList_Nouns);
                Print(item.LoadList_Verbs);
            }
        }

        public static void TestArea()
        {
            Print(Player.Location().areaName);
            Print(Player.Location().areaLook);
            Print(Player.Location().cinimatic.Count, "Cinematic");
            //print(Player.Location().cinimatic);
        }

        public static void Print (Dictionary<string,string> dic)
        {
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }

        public static void Print(bool TF)
        {
            string line = "False";
            if (TF)
                line = "True";
            Console.WriteLine(line + "\n");
        }

        public static void Print(string line)
        {
            Console.WriteLine(line + "\n");
        }

        public static void Print(int num, string title)
        {
            Console.WriteLine(title + " Total Lines = " + num + "\n");
        }

        public static void Print(List<string> list)
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
