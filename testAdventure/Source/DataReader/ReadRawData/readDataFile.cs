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