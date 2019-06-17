using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readVerbList
    {
        public static List<string> Get(string BracketStart, string BracketEnd, List<string> fileData)
        {
            List<string> data = new List<string>();
            data = readUniqueBrackets.Get(BracketStart, BracketEnd, fileData);
            return data;
        }
    }
}
