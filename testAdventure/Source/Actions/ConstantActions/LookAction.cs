using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class LookAction
    {
        private static PrintLook Look = new PrintLook();

        public static void Process(string target)
        {

            //DeBugging.Print(" * * Target : " + target);
            
            // Test Constants
            switch (target)
            {
                case "area":
                    Look.Print(Player.Location());
                    break;
                case "exit":
                    Look.AllExits();
                    break;
                case "inventori":
                    Console.WriteLine("\nNot Implemented : " + target);
                    break;
                case "map":
                    Console.WriteLine("\nNot Implemented : " + target);
                    break;
                default:
                    if (testExits(target))
                        testItems(target);
                    else
                    { }
                    break;
            }
        }

        private static bool testItems(string target)
        {
            List<Item> items = Player.Location().itemsList;
            foreach (Item item in items)
            {
                foreach (string name in item.LoadList_Nouns)
                {
                    if (name == target)
                    {
                        Look.Print(item.lookText);
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool testExits(string target)
        {
            List<Exit> exits = Player.Location().exitsList;
            foreach (Exit exit in exits)
            {
                if (exit.direction == target)
                {
                    Look.Print(exit.look);
                    return false;
                }
            }
            return true;
        }
    }
}
/*




            foreach(string word in CommandDictonary.List_ActionSingle())
            {
                if (word == target)
                {
                    //Look.Print();
                }
            }
        }
    }
}
*/