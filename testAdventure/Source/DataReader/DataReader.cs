using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class DataReader
    {
        public Area ImportAreaData(string filename)
        {
            AreaData read_AreaData = new AreaData(filename);
            Area newArea = read_AreaData.GetArea();
            return newArea;
        }
    }
}
