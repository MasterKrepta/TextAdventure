using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Room {

        public int locX;
        public int locY;
        public string[] possibleExits = { "up", "down", "left", "right"};


        public Room() {
            GetRoomData();
            for (int i = 0; i < possibleExits.Length; i++) {
                possibleExits[i].ToLower();
            }
        }

        void GetRoomData() {
            //TODO: Get the data from an external file
        }
       
}
}
