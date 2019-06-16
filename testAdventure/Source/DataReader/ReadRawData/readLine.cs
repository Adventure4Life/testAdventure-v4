using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readLine
    {
        public static string Get(string uniqueKeyword, List<string> fileData)
        {
            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(uniqueKeyword))
                {
                    string foundLine = CatagorieTxT.Cleaned(fileData[i], uniqueKeyword);
                    return foundLine;
                }
            }
            return null;
        }
    }
}
/*
        public static string Read_RawSingleLine(string uniqueKeyword, List<string> fileData)
        {
            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(uniqueKeyword))
                {
                    string foundLine = cleanCatagorieTxT(fileData[i], uniqueKeyword);
                    return foundLine;
                }
            }
            return null;
        }
 * */
