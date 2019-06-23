using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readListOfFiles
    {
        public static Dictionary<string, string> Get(string path, List<string> FilesNames)
        {
            Dictionary<string, string> returnData = new Dictionary<string, string>();

            foreach (string fileName in FilesNames)
            {
                List<string> Data_File = readDataFile.Load_DataFile(path, fileName);
                Safe.AddRange(returnData, BuildDictionaryFrom(Data_File));
            }
            //DeBugging.Print(returnData);
            return returnData;
        }

        public static Dictionary<string, string> BuildDictionaryFrom(List<string> synonyms)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string BaseWord = "//--BASE:";
            string BracketStart = "//Synonyms-START";
            string BracketEnd = "//Synonyms-END";

            string value = readLine.Get(BaseWord, synonyms);
            List<string> keys = readUniqueBrackets.Get(BracketStart, BracketEnd, synonyms);

            Safe.Add(data, value, value);
            foreach (string key in keys)
                Safe.Add(data, key, value);

            //DeBugging.Print(data);
            //DeBugging.Print("**************** end of " + value + " list *************************");
            return data;
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readListOfFiles
    {
        public static Dictionary<string, string> Get(string path, List<string> FilesNames)
        {
            Dictionary<string, string> returnData = new Dictionary<string, string>();

            foreach (string fileName in FilesNames)
            {
                List<string> Data_File = readDataFile.Load_DataFile(path, fileName);
                Safe.AddRange(returnData, BuildDictionaryFrom(Data_File, fileName));
            }
            //DeBugging.Print(returnData);
            return returnData;
        }

        private static Dictionary<string, string> BuildDictionaryFrom(List<string> synonyms, string value)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string BracketStart = "//Synonyms-START";
            string BracketEnd = "//Synonyms-END";

            List<string> keys = readUniqueBrackets.Get(BracketStart, BracketEnd, synonyms);
            Safe.Add(data, value, value);
            foreach (string key in keys)
                Safe.Add(data, key, value);

            //DeBugging.Print(data);
            //DeBugging.Print("**************** end of " + value + " list *************************");
            return data;
        }
    }
}
*/