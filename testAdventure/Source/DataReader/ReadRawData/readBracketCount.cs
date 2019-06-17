using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readBracketCount
    {
        public static BracketCounts Get (string BracketStart_Key, string BracketEnd_Key, List<string> fileData)
        {
            BracketCounts data = new BracketCounts();

            int bracketCount = 0;
            List<int> bracketIndex_Start = new List<int>();
            List<int> bracketIndex_End = new List<int>();

            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(BracketStart_Key))
                {
                    bracketIndex_Start.Add(i);
                    bracketCount++;
                }
                if (fileData[i].StartsWith(BracketEnd_Key))
                {
                    bracketIndex_End.Add(i);
                }
            }
            data.bracketCount = bracketCount;
            data.start = bracketIndex_Start;
            data.end = bracketIndex_End;

            return data;
        }
    }
}

/*
 public static BracketCounts Read_BracketCount(string BracketStart_Key, string BracketEnd_Key, List<string> fileData)
        {
            BracketCounts brackets = new BracketCounts();

            Dictionary<string, object> BracketData = new Dictionary<string, object>();
            int bracketCount = 0;
            List<int> bracketIndex_Start = new List<int>();
            List<int> bracketIndex_End = new List<int>();

            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(BracketStart_Key))
                {
                    bracketIndex_Start.Add(i);
                    bracketCount++;
                }
                if (fileData[i].StartsWith(BracketEnd_Key))
                {
                    bracketIndex_End.Add(i);
                }
            }

            brackets.bracketCount = bracketCount;
            brackets.start = bracketIndex_Start;
            brackets.end = bracketIndex_End;
            return brackets;
        }
 */
