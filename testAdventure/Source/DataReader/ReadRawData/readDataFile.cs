using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace testAdventure
{
    static class readDataFile
    {
        static private List<string> fileData = new List<string>();

        /// <summary>
        /// Reads an entire data file into memory. Each line stored in an element of List<string>
        /// </summary>
        /// <param name="path">Relitive Path to FileName from Application ExE</param>
        /// <param name="filename">Name of File to read</param>
        /// <returns></returns>
        static public List<string> Load_DataFile(string path, string filename)
        {
            List<string> ReadData_rawAll = new List<string>();
            string fullPath2File = Path.Combine(path, filename + FilePaths.Ext);

            foreach (string line in File.ReadLines(fullPath2File))
            {
                //if (line != "")
                //{
                ReadData_rawAll.Add(line);
                //}
            }
            fileData = ReadData_rawAll.ToList();
            return ReadData_rawAll;
        }
    }
}

/*        
 
    

 *        
 *        
 *        
 *        public static string Read_RawSingleLine(string uniqueKeyword, List<string> fileData)
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

        //Between Brackets, Read RAW lines into a List<string>
        public static List<string> BetweenUniqueBrackets(string start, string end)
        {
            List<string> data = new List<string>();
            int[] brackets = ReadDataFile.FindUniqueBrackets(start, end, fileData);
            data = ReadDataFile.Read_Cinamatic(brackets[0], brackets[1], fileData);
            return data;
        }

        private static string cleanCatagorieTxT(string line, string keyWord)
        {
            if (line.StartsWith(keyWord))
            {
                int s = keyWord.Length;
                int l = line.Length - keyWord.Length;
                line = line.Substring(s, l);
            }
            return line.Trim();
        }

        // This finds the index value for the start and the end of any unique Brackets.
        public static int[] FindUniqueBrackets(string start, string end, List<string> fileData)
        {
            int[] found = new int[2];
            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(start)) { found[0] = i; }
                if (fileData[i].StartsWith(end)) { found[1] = i; }
            }
            return found;
        }

        // Reads full line data between index values of the Brackets
        public static List<string> Read_Cinamatic(int start, int end, List<string> fileData)
        {
            List<string> data = new List<string>();

            for (int i = start + 1; i < end; i++)
            {
                data.Add(fileData[i].Trim());
            }
            return data;
        }

        public static List<string> Read_WordLists(int start, int end, List<string> fileData)
        {
            List<string> data = new List<string>();

            for (int i = start + 1; i < end; i++)
            {
                data.Add(fileData[i].Trim());
            }
            return data;
        }

        public static string ReadData_LinesInsideBrackets(string uniqueKeyword, List<string> fileData, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (fileData[i].StartsWith(uniqueKeyword))
                {
                    //Console.WriteLine("DEBUG uniqueKeyword : " + uniqueKeyword);
                    string foundLine = cleanCatagorieTxT(fileData[i], uniqueKeyword);
                    return foundLine;
                }
            }
            return null;
        }

        //public static Dictionary<string, object> Read_BracketCount(string BracketStart_Key, string BracketEnd_Key, List<string> fileData)
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
        }*/
