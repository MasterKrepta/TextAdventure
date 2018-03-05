using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Inventory {

        public List<string> playerInventory = new List<string>();
        public List<string> roomInventory = new List<string>();

        public Inventory() {
            playerInventory.Add("knife");
            playerInventory.Add("shovel");
            playerInventory.Add("pen");

            roomInventory.Add("room");

            foreach (string item in playerInventory) {
                item.ToLower();
            }
            foreach (string item in roomInventory) {
                item.ToLower();
            }
        }



        void PopulateRoomInventory() {
            //TODO: Get inventory from our room and add it to the list
        }
    }
}
