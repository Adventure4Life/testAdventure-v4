using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class AreaUtilities
    {
        public static void ActivateArea(Area area)
        {
            switch (Player.Location().hasBeenEntered)
            {
                case false:
                    {
                        Player.Location().setEntered(); // Set Bool Value so app knows we have been here before
                        FrameBuffer.ClearType();
                        FrameBuffer.type = area.cinimatic;
                        //TODO : Re-Enable the print stuff in here!
                        //PrintBuffer.PrintType();
                        break;
                    }
                case true:
                    { break; }
            }
            //TODO : Move Dynamic List thing to Move Code, only trigger on move success.
            CommandDictonary.Initilise_DynamicVerbs(Player.Location());
            //CommandDictonary.Initilise_DynamicNouns(Player.Location());
        }
    }
}
