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
        public bool hasEnteredAreaBefore { get; set; }
        public string areaName { get; set; }
        public string areaLook { get; set; }
        public List<string> cinimatic { get; set; }
        public List<Exit> exitsFromArea { get; set; }
        public List<Item> itemsInRoom { get; set; }

        //Constructor
        public Area()
        {
            //fill variables with placeholder data
            areaName = "<areaName goes here>";
            hasEnteredAreaBefore = false;
            areaLook = "<description goes here>";
            cinimatic = new List<string>();
            exitsFromArea = new List<Exit>();
            itemsInRoom = new List<Item>();
        }

        //Initialize Data to be called by 
        public void SetName(string importLine){
            areaName = importLine;}
        
        public void SetLook_Description(string importLine){
            areaLook = importLine;}

        public void SetCinimatic(List<string> c){
            cinimatic = new List<string>(c);}

        public void AddExit(Exit exit){
            exitsFromArea.Add(exit);}

        public void AddItem(Item item){
            itemsInRoom.Add(item);}
    }
}
