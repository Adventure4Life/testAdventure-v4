using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class ProcessCommands
    {
        private static string rawInput;
        private static string[] cleanedInputTokens;
        private static string[] stemmedInputTokens;

        public ProcessCommands()
        {
            rawInput = UserInput.GetRawInput();
            cleanedInputTokens = UserInput.GetCleanedInputTokens().Clone() as string[];
            stemmedInputTokens = UserInput.GetStemmedInputTokens().Clone() as string[];
            #region DEBUGGING PRINTOUTS of Variables.
            /*
            Console.WriteLine("ProcessCommands Constructor");
            Console.WriteLine("rawInput : " + rawInput);
            foreach (string word in cleanedInputTokens)
                Console.WriteLine("cleanedInputTokens : " + word);
            foreach (string word in stemmedInputTokens)
                Console.WriteLine("stemmedInputTokens : " + word);
            */
            //ProcessInputData(); // Moved to UserInputs.GetInput()
            //examine
            //Console.WriteLine("DEBUG 'examine': "+ CommandDictonary.actionsConstant["examine"]);
            //string Stemmed = TextUtils.StemWord.Stem("examine").Value;
            //Console.WriteLine("Stemmed Command : "+Stemmed);
            #endregion
        }

        public void ProcessInputData()
        {
            if (stemmedInputTokens.Length == 1)
            {
                CMDsSingle.Process(stemmedInputTokens[0]);
            }
            else if (stemmedInputTokens.Length > 1)
            {
                CMDsMultiple.Process(stemmedInputTokens);
            }
        }
    }
}
