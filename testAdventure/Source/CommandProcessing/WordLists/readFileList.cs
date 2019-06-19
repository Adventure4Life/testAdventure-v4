using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readFileList
    {
        public static List<string> Get(string path)
        {
            string fileName = "_ListofWords";
            List<string> Data_FileList = readDataFile.Load_DataFile(path, fileName);

            string start = "//List-START";
            string end = "//List-END";
            List<string> files = readUniqueBrackets.Get(start, end, Data_FileList);

            return files;
        }
    }
}
