using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class CommandDictonary
    {
        private static Dictionary<string, string> Action_Constants;
        private static Dictionary<string, string> Action_Single;
        private static Dictionary<string, string> Action;
        private static Dictionary<string, string> Object;

        private static List<string> ActionSingle_List;
        private static List<string> ActionConstants_List;

        private static Dictionary<string, string> LookSingle;

        //public static Dictionary<string, string> Constant_Actions() => Action_Constants;
        public static Dictionary<string, string> Single_Actions() => Action_Single;
        public static Dictionary<string, string> Actions() => Action;
        public static Dictionary<string, string> Objects() => Object;
        public static Dictionary<string, string> Constants() => Action_Constants;
        public static Dictionary<string, string> SingleLook() => LookSingle;

        public static List<string> List_ActionSingle() => ActionSingle_List;
        public static List<string> List_ActionConstant() => ActionConstants_List;


        public static void Initialise()
        {
            ActionSingle_List = readFileList.Get(FilePaths.ActionSingles);
            ActionConstants_List = readFileList.Get(FilePaths.ActionConstants);

            readActionList ImportConstants = new readActionList(FilePaths.ActionConstants);
            Action_Constants = ImportConstants.Get();

            readActionList ImportSingles = new readActionList(FilePaths.ActionSingles);
            Action_Single = ImportSingles.Get();

            //Load Special Case for LOOK command (HACK)
            List<string> fileData = readDataFile.Load_DataFile(FilePaths.Special, "look").ToList();
            LookSingle = readListOfFiles.BuildDictionaryFrom(fileData);

            // Add LOOK to Command Constants
            Safe.AddRange(Action_Constants, LookSingle);


        }

        public static void Initilise_DynamicVerbs(Area area)
        {
            readDynamicWords DynamicWordList = new readDynamicWords(area.itemsList);

            Action = new Dictionary<string, string>();
            Action.Clear();
            Action = DynamicWordList.Get_Verbs();

            Safe.AddRange(Action, Action_Constants);

            /*DeBugging.Print(Action_Constants);
            DeBugging.Pause();*/
        }

        public static void Initilise_DynamicNouns(Area area)
        {
            readDynamicWords DynamicWordList = new readDynamicWords(area.itemsList);

            Object = new Dictionary<string, string>();
            Object.Clear();
            Object = DynamicWordList.Get_Nouns();

            Safe.AddRange(Object, Action_Single);
        }
    }
}