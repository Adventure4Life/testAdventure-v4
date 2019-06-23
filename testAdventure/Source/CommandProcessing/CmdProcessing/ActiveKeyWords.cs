using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class ActiveKeyWords
    {
        static public List<string> FindActions (string[] cmds)
        {
            List<string> returnData = new List<string>();


            foreach (string Constants in cmds)
                Safe.AddNoBlanks(returnData, MatchSynonym.ToConstants(Constants));

            foreach (string actions in cmds)
                Safe.AddNoBlanks(returnData, MatchSynonym.ToActions(actions));

            return returnData.Distinct().ToList();
        }

        static public List<string> FindObjects(string[] cmds)
        {
            List<string> returnData = new List<string>();

            foreach (string obj in cmds)
                Safe.AddNoBlanks(returnData, MatchSynonym.ToObjects(obj));

            return returnData.Distinct().ToList();
        }
    }
}
