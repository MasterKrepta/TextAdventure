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


        public Room() {

        }
        public Room(string incomingData) {
                AssignRoomDetails(incomingData);
                possibleExits.ToLower();
            
        }

        public void AssignRoomDetails(string nextRoomData) {
            possibleExits = "";

            string[] data = nextRoomData.Split(',');
            locX = Int32.Parse(data[0]);
            locY = Int32.Parse(data[1]);
            for (int i = 2; i < data.Length; i++) {
                possibleExits += data[i] + " ";
                //Console.WriteLine(possibleExits + " is in this room");
            }

            //SAVE FOR DEBUGING
            //Console.WriteLine("\n room is :  " + locX + " || " + locY + " || " + possibleExits);
            //foreach (var detail in data) {
            //    Console.WriteLine($"\nData is <{detail}>");
            //}
        }

        public StringBuilder DisplayRoomDescription() {
            StringBuilder desc = new StringBuilder();
            desc.AppendFormat( "\n Description for current room " + locX + " " + locY);
            Console.WriteLine(desc.ToString());
            return desc;
        }



    }
}
