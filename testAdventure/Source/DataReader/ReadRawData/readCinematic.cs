using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readCinematic
    {
        public static List<string> Get (string CinimaStart, string CinimaEnd, List<string> fileData)
        {
            List<string> data = new List<string>();
            data = readUniqueBrackets.Get(CinimaStart, CinimaEnd, fileData);
            return data;
        }
    }
}
