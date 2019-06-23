using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class CMDsMultiple
    {
        public static void Process(string[] input)
        {
            List<string> ActionList = ActiveKeyWords.FindActions(input);
            List<string> ObjectList = ActiveKeyWords.FindObjects(input);

            if (ActionList.Count == 1 && ObjectList.Count == 1)
            {
                //DeBugging.Print(ActionList[0] + ObjectList[0]);
                actionSimple.Process(ActionList[0], ObjectList[0]);
            }
        }
    }
}
