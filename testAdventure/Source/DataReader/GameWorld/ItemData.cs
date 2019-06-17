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

/*
    class DataRead_Items
    {
        private List<string> fileData;
        private string fileName;
        private Items item;
        private ItemKeys itemKeys;

        // Return Item() 
        public Items GetItem()
        { return item; }

        public DataRead_Items(string name)
        {
            item = new Items();
            itemKeys = new ItemKeys();
            fileName = name;
            fileData = ReadDataFile.Load_DataFile(FilePaths.Items, fileName);
            ProcessData();
            ProcessNouns();
            ProcessVerbs();
        }

        private void ProcessData()
        {
            //Console.WriteLine("Processing : " + fileName);
            item.name = ReadDataFile.Read_RawSingleLine(itemKeys.itemName, fileData);
            item.PickedupAllowed = ReadDataFile.Read_RawSingleLine(itemKeys.itemCanBePickedip, fileData).Equals("true"); //reads a text string "true" or "false". if that is "equal to true" it returns "bool true", otherwise return "bool false"

            item.lookDescription = ReadDataFile.Read_RawSingleLine(itemKeys.lookDescription, fileData);
            item.getItem = ReadDataFile.Read_RawSingleLine(itemKeys.itemGet, fileData);
        }

        private void ProcessNouns()
        {
            List<string> words = new List<string>();
            BracketCounts brackets = new BracketCounts();
            brackets = ReadDataFile.Read_BracketCount(itemKeys.nStart, itemKeys.nEnd, fileData);
            for (int i = brackets.start[0] + 1; i < brackets.end[0]; i++)
            {
                words.Add(fileData[i]);
                //Console.WriteLine(fileData[i]);
            }
            item.LoadList_ActiveNouns = words.ToList();
            //DeBugging.Pause();
        }

        private void ProcessVerbs()
        {
            //TODO MARKER: Form NOUN LISTS
            List<string> words = new List<string>();
            BracketCounts brackets = new BracketCounts();
            brackets = ReadDataFile.Read_BracketCount(itemKeys.vStart, itemKeys.vEnd, fileData);
            for (int i = brackets.start[0] + 1; i < brackets.end[0]; i++)
            {
                words.Add(fileData[i]);
                //Console.WriteLine(fileData[i]);
            }
            item.LoadList_ActiveVerbs = words.ToList();
            //DeBugging.Pause();
        }
    }
}
*/