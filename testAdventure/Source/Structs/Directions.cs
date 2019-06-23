using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Directions
    {
        public string North { get; }
        public string South;
        public string East;
        public string West;
        public Dictionary<string, int> Exit;

        public Directions()
        {
            North = "north";
            South = "south";
            East = "east";
            West = "west";

            Exit = new Dictionary<string, int>();
            Exit.Add("north", 0);
            Exit.Add("south", 1);
            Exit.Add("east", 2);
            Exit.Add("west", 3);
        }
    }
}
