using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class ItemData
    {
        private const string KeyName = "//--ITEM_NAME:";
        private const string KeyGetable = "//--ITEM_CAN_BE_PICKED_UP:";

        private const string KeyLookTxt = "//--LOOK_DESCRIPTION:";
        private const string KeyGetTxt = "//--GET_ITEM:";

        private const string nStart = "//--NOUN-START";
        private const string nEnd = "//--NOUN-END";

        private const string vStart = "//--VERB-START";
        private const string vEnd = "//--VERB-END";

        private List<string> fileData;
        private string fileName;
        private Item item;

        // Return Item() 
        public Item GetItem() => item;

        public ItemData(string name)
        {
            item = new Item();
            fileName = name;
            fileData = readDataFile.Load_DataFile(FilePaths.Items, fileName).ToList();
            ProcessData();
        }

        private void ProcessData()
        {
            item.name = readLine.Get(KeyName, fileData);
            item.AllowGet = readLine.Get(KeyGetable, fileData).Equals("true"); //reads a text string. if that is "equal" to "true" it returns "bool true", otherwise return "bool false";
            item.lookText = readLine.Get(KeyLookTxt, fileData);
            item.getText = readLine.Get(KeyGetTxt, fileData);
            item.LoadList_Nouns = readNounList.Get(nStart, nEnd, fileData);
            item.LoadList_Verbs = readVerbList.Get(vStart, vEnd, fileData);
        }
    }
}