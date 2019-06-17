using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Area
    {
        //Data Variables
        public bool hasBeenEntered { get; set; }
        public string areaName { get; set; }
        public string areaLook { get; set; }
        public List<string> cinimatic { get; set; }
        public List<Item> itemsList { get; set; }
        public List<Exit> exitsList { get; set; }

        //Constructor
        public Area()
        {
            //fill variables with placeholder data
            areaName = "<areaName goes here>";
            hasBeenEntered = false;
            areaLook = "<description goes here>";
            cinimatic = new List<string>();
            itemsList = new List<Item>();
            exitsList = new List<Exit>();
        }
    }
}
