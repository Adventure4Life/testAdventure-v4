using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class DynamicWordLists
    {
        static public void Build()
        {
            //DeBugging.Print("Build Verb and Nouns List");
            CommandDictonary.Initilise_DynamicVerbs(Player.Location());
            CommandDictonary.Initilise_DynamicNouns(Player.Location());
        }
    }
}
