using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readUniqueBrackets
    {

        public static List<string> Get(string BracketStart, string BracketEnd, List<string> fileData)
        {
            List<string> data = new List<string>();

            // Determine [i] for start and end of brackets
            int start = new int();
            int end = new int();

            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(BracketStart)) { start = i; }
                if (fileData[i].StartsWith(BracketEnd)) { end = i; }
            }

            for (int i = start + 1; i < end; i++)
            {
                data.Add(fileData[i].Trim());
            }

            return data;
        }
    }
}