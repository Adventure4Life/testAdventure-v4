using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class MatchSynonym
    {
        static public string ToSinglesCommands (string input)
        {
            string cmd = String.Empty;
            Dictionary<string, string> activeCommands = new Dictionary<string,string>(CommandDictonary.Single_Actions());
            Safe.AddRange(activeCommands, CommandDictonary.SingleLook());

            if (activeCommands.ContainsKey(input))
            {
                //DeBugging.Print("Found Input    : " + input);
                //DeBugging.Print("Command Equals : " + activeCommands[input]);
                cmd = activeCommands[input];
            }
            return cmd;
        }
        
        static public string ToConstants(string input)
        {
            string cmd = String.Empty;
            Dictionary<string, string> activeCommands = CommandDictonary.Constants();

            if (activeCommands.ContainsKey(input))
            {
                //DeBugging.Print("Found Input    : " + input);
                //DeBugging.Print("Command Equals : " + activeCommands[input]);
                cmd = activeCommands[input];
            }
            return cmd;
        }
        static public string ToObjects(string input)
        {
            string cmd = String.Empty;
            Dictionary<string, string> activeCommands = CommandDictonary.Objects();

            if (activeCommands.ContainsKey(input))
            {
                //DeBugging.Print("Found Input    : " + input);
                //DeBugging.Print("Command Equals : " + activeCommands[input]);
                cmd = activeCommands[input];
            }
            return cmd;
        }

        static public string ToActions(string input)
        {
            string cmd = String.Empty;
            Dictionary<string, string> activeCommands = CommandDictonary.Actions();

            if (activeCommands.ContainsKey(input))
            {
                //DeBugging.Print("Found Input    : " + input);
                //DeBugging.Print("Command Equals : " + activeCommands[input]);
                cmd = activeCommands[input];
            }
            return cmd;
        }
    }
}
