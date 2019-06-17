using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class AreaData
    {
        private const string KeyName = "//--AREA_NAME:";
        private const string KeyLook = "//--AREA_LOOK:";

        private const string CinimaStart = "//--AREA_CINAMATIC_START:";
        private const string CinimaEnd = "//--AREA_CINAMATIC_END:";

        private const string ItemStart = "//LIST_OF_ITEMS_IN_AREA--START";
        private const string ItemEnd = "//LIST_OF_ITEMS_IN_AREA--END";

        private const string ExitStart = "//-EXIT_START";
        private const string ExitEnd = "//-EXIT_END";

        private List<string> fileData;
        private string fileName;
        private Area area;

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
            area.areaLook = readLine.Get(KeyLook, fileData);
            area.cinimatic = readCinematic.Get(CinimaStart, CinimaEnd, fileData);
            area.itemsList = readItems.Get(ItemStart, ItemEnd, fileData);
            area.exitsList = readExits.Get(ExitStart, ExitEnd, fileData);
        }
    }
}
   