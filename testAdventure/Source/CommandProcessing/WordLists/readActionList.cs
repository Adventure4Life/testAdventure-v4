using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class readActionList
    {
        private Dictionary<string, string> returnActions = new Dictionary<string, string>();
        public Dictionary<string, string> Get() => returnActions;

        public readActionList(string path)
        {
            List<string> FilesNames = readFileList.Get(path); // Load in List of Files to Load
            returnActions = readListOfFiles.Get(path, FilesNames);
        }
    }
}
