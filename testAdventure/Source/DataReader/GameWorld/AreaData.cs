using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class AreaData
    {
        private List<string> fileData;
        private string fileName;
        private Area area;

        private const string KeyName = "//--AREA_NAME:";
        private const string KeyDescription = "//--AREA_LOOK:";
        private const string CinimaStart = "//--AREA_CINAMATIC_START:";
        private const string CinimaEnd = "//--AREA_CINAMATIC_END:";

        //Return Area
        public Area GetArea() => area;

        //Constructor
        public AreaData(string name)
        {
            area = new Area();
            fileName = name;
            fileData = readDataFile.Load_DataFile(FilePaths.Areas, fileName).ToList();
            ProcessData();
        }

        private void ProcessData()
        {
            area.areaName = readLine.Get(KeyName, fileData);
            area.areaLook = readLine.Get(KeyDescription, fileData);
            area.cinimatic = readUniqueBrackets.Get(CinimaStart, CinimaEnd, fileData);
            ProcessAllItems();
        }

        private void ProcessAllItems()
        {

        }
    }
    /*
     * 
     *            BracketCounts brackets = new BracketCounts();
            brackets = ReadDataFile.Read_BracketCount(areaKeys.itemsStart, areaKeys.itemsEnd, fileData);
            for (int i = brackets.start[0] + 1; i < brackets.end[0]; i++)
            {
                DataRead_Items BuildItem = new DataRead_Items(fileData[i]);
                area.AddItem(BuildItem.GetItem());
            }
     * 
    class AreaKeys
    {
        public string areaName { get; }
        public string areaLook_Description { get; }

        public string CinimaStart { get; }
        public string CinimaEnd { get; }

        public string exitStart { get; }
        public string exitEnd { get; }

        public string itemsStart { get; }
        public string itemsEnd { get; }

        public AreaKeys()
        {
            areaName = "//--AREA_NAME:";
            areaLook_Description = "//--AREA_LOOK:";

            CinimaStart = "//--AREA_CINAMATIC_START:";
            CinimaEnd = "//--AREA_CINAMATIC_END:";

            exitStart = "//-EXIT_START";
            exitEnd = "//-EXIT_END";

            itemsStart = "//LIST_OF_ITEMS_IN_AREA--START";
            itemsEnd = "//LIST_OF_ITEMS_IN_AREA--END";
        }

    }*/
}
