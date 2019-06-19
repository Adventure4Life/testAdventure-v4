using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class TextUtils
    {
        static public EnglishPorter2Stemmer StemWord = new EnglishPorter2Stemmer();

        public static string[] TokenizeStringList(string input)
        {
            List<string> cleanedInputList = new List<string>();
            string[] raw_cleanedInputString = input.ToLower().Trim().Split(null);

            foreach (string word in raw_cleanedInputString)
            {
                if (word != "")
                {
                    string s = CleanedWord(word);
                    if (s != "") cleanedInputList.Add(s);
                }
            }

            string[] copyList2String = new string[cleanedInputList.Count];
            cleanedInputList.CopyTo(copyList2String);
            return copyList2String;
        }

        //Clean Unwanted Characters from a string
        public static string CleanedWord(string word)
        {
            var banList = "~`!@#$%^&*()_+{}|[]\\:;\",<.>/?".ToCharArray();
            return string.Join("", word.Where(s => !banList.Contains(s)));
        }

        //Stemming string[] (Overloaded)
        public static string[] StemWordList(string[] wordlist)
        {
            string[] copyArray = wordlist.ToArray();
            for (int i = 0; i < copyArray.Length; i++)
            {
                string StemValue = StemWord.Stem(copyArray[i]).Value;
                copyArray[i] = StemValue;
            }
            return copyArray;
        }

        //Stemming List<string> (Overloaded)
        public static List<string> StemWordList(List<string> wordlist)
        {
            List<string> copyArray = wordlist.ToList();
            for (int i = 0; i < copyArray.Count; i++)
            {
                string StemValue = StemWord.Stem(copyArray[i]).Value;
                copyArray[i] = StemValue;
            }
            return copyArray;
        }

        public static string WordWrap(string text)
        {
            text = "      " + text;
            string result = "";
            int bufferWidth = Console.WindowWidth;
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                int linelength = 0;
                string[] words = line.Split(' ');

                foreach (string word in words)
                {
                    //if (word.Length + linelength >= bufferWidth - 1)
                    if (word.Length + linelength >= bufferWidth - 7)
                    {
                        result += "\n      ";
                        linelength = 0;
                    }
                    result += word + " ";
                    linelength += word.Length + 1;
                }
                result += "\n";
            }
            return result;
        }

        public static string WordWrap(List<string> text)
        {
            string result = "";

            foreach (string line in text)
            {
                result = result + line;
            }
            return result;
        }
    }
}
