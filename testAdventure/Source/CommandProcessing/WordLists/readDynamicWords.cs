using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class readDynamicWords
    {
        private readonly List<Item> ItemList;

        public readDynamicWords(List<Item> items)
        {
            ItemList = new List<Item>(items);
        }

        public Dictionary<string, string> Get_Verbs()
        {
            Dictionary<string, string> returnData = new Dictionary<string, string>();
            List<string> LoadList = new List<string>();

            foreach (Item item in ItemList)
            {
                foreach (string word in item.LoadList_Verbs)
                {
                    Safe.Add(LoadList, word);
                }
            }

            Safe.Remove(LoadList, CommandDictonary.List_ActionConstant());
            Safe.Remove(LoadList, CommandDictonary.List_ActionSingle());
            
            returnData = readListOfFiles.Get(FilePaths.Actions, LoadList);
            return returnData;
        }

        public Dictionary<string, string> Get_Nouns()
        {
            Dictionary<string, string> returnData = new Dictionary<string, string>();
            List<string> LoadList = new List<string>();

            foreach (Item item in ItemList)
            {
                foreach (string word in item.LoadList_Nouns)
                {
                    Safe.Add(LoadList, word);
                }
            }

            //Safe.Remove(LoadList, CommandDictonary.List_ActionConstant());
            //Safe.Remove(LoadList, CommandDictonary.List_ActionSingle());

            returnData = readListOfFiles.Get(FilePaths.Actions, LoadList);
            return returnData;
        }
    }
}
