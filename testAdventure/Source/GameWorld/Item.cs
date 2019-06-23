using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Item
    {
        //Private Variables
        public string name { get; set; } = "";
        public bool AllowGet { get; set; } = true;
        public string lookText { get; set; } = "???";
        public string getText { get; set; } = "";

        public List<String> LoadList_Nouns { get; set; } = new List<String>();
        public List<String> LoadList_Verbs { get; set; } = new List<String>();
    }
}
