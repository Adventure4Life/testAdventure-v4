using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class readItems
    {
        public static List<Item> Get(string ItemStart, string ItemEnd, List<string> fileData)
        {
            List<Item> data = new List<Item>();

            List<string> itemNameList = new List<string>();
            itemNameList = readUniqueBrackets.Get(ItemStart, ItemEnd, fileData);

            foreach (string itemName in itemNameList)
            {
                ItemData read_ItemData = new ItemData(itemName);
                data.Add(read_ItemData.GetItem());
            }
            return data;
        }
    }
}
