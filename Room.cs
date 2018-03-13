using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Room {

        private int locX;
        private int locY;

        public int LocX { get => locX; set => locX = value; }
        public int LocY { get => locY; set => locY = value; }

        private List<string> exitsInRoom = new List<string>();
        private List<string> itemsinRoom = new List<string>();

        public List<string> ItemsinRoom { get => itemsinRoom; set => itemsinRoom = value; }


        public Room() {
            exitsInRoom = new List<string>();
            itemsinRoom = new List<string>();
        }

        public Room(string incomingData) {
            exitsInRoom = new List<string>();
            itemsinRoom = new List<string>();
            AssignRoomDetails(incomingData);
            
        }



        public void AssignRoomDetails(string nextRoomData) {
            string[] data = nextRoomData.Split(',');
            LocX = Int32.Parse(data[0]);
            LocY = Int32.Parse(data[1]);
            for (int i = 2; i < data.Length; i++) {
                exitsInRoom.Add(data[i]);
                //Console.WriteLine("room created at " + locX + " , " + locY + " with exits: " + data[i]);
            }
        }
        public void GetItem() {
            //TODO Set up item class
        }

        public bool CanExit(string dir) {
            foreach(string valid in exitsInRoom) {
                if (dir == valid) {
                    return true;
                }
            }
            return false;
        }       


        private string GetItems() {
            return  "";
        }

        private string GetExits() {
            string exitsString = "";
            string display = "Possible Exits are: ";
            foreach(string exit in exitsInRoom) {
                exitsString += "  " + exit;
            }
            return "\n" + display + exitsString;
        }

        private string GetLocation() {
            return "\nWe are in room " + LocX + " , " + LocY;

        }
        
        public void DescribeRoom() {
            StringBuilder desc = new StringBuilder();
            desc.AppendFormat( "\n Description for current room " + LocX + " " + LocY);
            
            Console.WriteLine(desc.ToString());
            Console.WriteLine(GetExits());
        }



    }
}
