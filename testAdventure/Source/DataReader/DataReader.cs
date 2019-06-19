using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class DataReader
    {
        public Area ImportAreaData(string filename)
        {
            AreaData read_AreaData = new AreaData(filename);
            Area newArea = read_AreaData.GetArea();
            return newArea;
        }

        public Dictionary<string, string> ImportCommands_Singles()
        {
            //DataRead_WordLists cmdSinglesPhraser = new DataRead_WordLists(ListOfWords);
            //Dictionary<string, string> cmdlist = cmdSinglesPhraser.ProcessAll_SingleCommands();
            Dictionary<string, string> cmdlist = new Dictionary<string, string>();
            return cmdlist;
        }

    }
}
