﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testAdventure
{
    static class UserInput
    {
        //Public Variables
        private static string rawInput;
        private static string[] cleanedInputTokens;
        private static string[] stemmedInputTokens;

        #region Get-ers
        public static string GetRawInput() => rawInput;
        public static string[] GetCleanedInputTokens() => cleanedInputTokens;
        public static string[] GetStemmedInputTokens() => stemmedInputTokens;
        #endregion

        public static void GetInput(string input)
        {
            rawInput = Regex.Replace(input, @"\s+", " "); //make sure there is only 1 white space between each word.
            cleanedInputTokens = TextUtils.TokenizeStringList(rawInput);
            stemmedInputTokens = TextUtils.StemWordList(cleanedInputTokens);
            #region DEBUGGING PRINTOUTS of Variables.
            /*
            Console.WriteLine("UserInput.GetInput()");
            Console.WriteLine("rawInput : " + rawInput);
            foreach (string word in cleanedInputTokens)
                Console.WriteLine("cleanedInputTokens : " + word);
            foreach (string word in stemmedInputTokens)
                Console.WriteLine("stemmedInputTokens : " + word);
            */
            #endregion

            ProcessCommands CmdProcessor = new ProcessCommands();
            CmdProcessor.ProcessInputData();
        }

        public static void AnyKeyContinue()
        {
            Console.CursorVisible = false;
            Console.Write("\n\n");
            Pause_AnyKey();
            Console.CursorVisible = true;
        }

        public static void Pause_AnyKey()
        {
            do { } // do nothing in here.. just loop so it acts like a pause
            while (!Console.KeyAvailable); // when a key is pressed it breaks the loop
            ClearInput();
        }

        public static void ClearInput()
        {   //Loop through any inputs in the input buffer and "spend them" doing nothing.
            while (Console.KeyAvailable) { Console.ReadKey(true); }
        }
    }
}
