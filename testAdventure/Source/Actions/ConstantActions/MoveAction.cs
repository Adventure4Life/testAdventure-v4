using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class MoveAction
    {
        public static void Process(string target)
        {
            foreach (string word in CommandDictonary.List_ActionSingle())
            {
                if (word == target)
                    CMDsSingle.ProcessMove(target);
            }
        }
    }
}
