using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class CatagorieTxT
    {
        public static string Cleaned(string line, string keyWord)
        {
            if (line.StartsWith(keyWord))
            {
                int s = keyWord.Length;
                int l = line.Length - keyWord.Length;
                line = line.Substring(s, l);
            }
            return line.Trim();
        }
    }
}
