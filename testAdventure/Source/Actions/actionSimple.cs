using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class actionSimple
    {
        static public void Process(string action, string obj)
        {
            //TODO : Add in this stuff!!
            //DeBugging.Print("Received Commands (actionSimple)");
            //DeBugging.Print("Action : " + action + "\nObject : " + obj);
            //DeBugging.Pause();

            switch (action)
            {
                case "move":
                    MoveAction.Process(obj);
                    break;
                case "look":
                    LookAction.Process(obj);
                    break;
            }
        }
    }
}
