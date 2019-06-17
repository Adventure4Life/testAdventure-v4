using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class ExitData
    {
        private const string KeyName = "--NAME:";
        private const string KeyDirection = "--DIRECTION:";

        private const string KeyAvaliable = "--AVAILABLE:";
        private const string KeyIsOpen = "--IS_OPEN:";

        private const string KeyLook = "--LOOK_AT_EXIT:";
        private const string KeyMove = "--Move_Through_Exit:";

        private List<string> fileData;
        private Exit exit;
        private int bracketIndex_Start;
        private int bracketIndex_End;

        //Return Area
        public Exit GetExit() => exit;

        //Constructor
        public ExitData(int BI_Start, int BI_End, List<string> file)
        {
            exit = new Exit();
            fileData = file;
            bracketIndex_Start = BI_Start;
            bracketIndex_End = BI_End;
            ProcessData();
        }

        private void ProcessData()
        {
            exit.name = readLine.Get(KeyName, fileData, bracketIndex_Start, bracketIndex_End);
            exit.direction = readLine.Get(KeyDirection, fileData, bracketIndex_Start, bracketIndex_End);

            exit.avaliable = readLine.Get(KeyAvaliable, fileData, bracketIndex_Start, bracketIndex_End).Equals("true");
            exit.open = readLine.Get(KeyIsOpen, fileData, bracketIndex_Start, bracketIndex_End).Equals("true");

            exit.look = readLine.Get(KeyLook, fileData, bracketIndex_Start, bracketIndex_End);
            exit.move = readLine.Get(KeyMove, fileData, bracketIndex_Start, bracketIndex_End);
        }

    }
}
