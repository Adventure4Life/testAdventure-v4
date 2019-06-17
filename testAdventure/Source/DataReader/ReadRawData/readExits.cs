using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readExits
    {
        public static List<Exit> Get(string BracketStart, string BracketEnd, List<string> fileData)
        {
            List<Exit> data = new List<Exit>();

            BracketCounts brackets = new BracketCounts();
            brackets = readBracketCount.Get(BracketStart, BracketEnd, fileData);

            int exitAmount = brackets.bracketCount;
            List<int> bracketIndex_Start = brackets.start as List<int>;
            List<int> bracketIndex_End = brackets.end as List<int>;

            for (int i = 0; i < exitAmount; i++)
            {
                ExitData BuildExits = new ExitData(bracketIndex_Start[i], bracketIndex_End[i], fileData);
                data.Add(BuildExits.GetExit());
            }

            return data;
        }
    }   
}

/*
             BracketCounts brackets = new BracketCounts();
            brackets = ReadDataFile.Read_BracketCount(areaKeys.exitStart, areaKeys.exitEnd, fileData);


        }
   */
