using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Room {

        public int locX;
        public int locY;
        public string possibleExits = "";
        

        public Room(string incomingData) {

                AssignRoomDetails(incomingData);
                RoomDescription();
                possibleExits.ToLower();
            
        }

        void AssignRoomDetails(string nextRoomData) {
            
            string[] data = nextRoomData.Split(',');
            locX = Int32.Parse(data[0]);
            locY = Int32.Parse(data[1]);
            for (int i = 2; i < data.Length; i++) {
                possibleExits += data[i] + ' ';
            }

            //SAVE FOR DEBUGING
            //Console.WriteLine("\n room is :  " + room.locX + " || " + room.locY);
            //Console.WriteLine("\n Possible Exits are: " + room.possibleExits);
            //foreach (var detail in data) {
            //    Console.WriteLine($"\nData is <{detail}>");
            //}
            
        }

        StringBuilder RoomDescription() {
            StringBuilder desc = new StringBuilder();
            desc.AppendFormat( "\n Description for current room " + locX + " " + locY);
            return desc;
        }



    }
}
