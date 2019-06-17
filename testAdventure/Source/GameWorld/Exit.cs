using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Exit
    {
        public string name { get; set; } = "";
        public string direction { get; set; } = "";

        public bool avaliable { get; set; } = false;
        public bool open { get; set; } = false;

        public string look { get; set; } = "";
        public string move { get; set; } = "";
    }
}
