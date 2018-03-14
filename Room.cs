using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    
    class Room {
        

        private int locX;
        private int locY;
        private string description;
        public int LocX { get => locX; set => locX = value; }
        public int LocY { get => locY; set => locY = value; }

        private List<string> exitsInRoom = new List<string>();
        private List<string> itemsinRoom = new List<string>();

        public List<string> ItemsinRoom { get => itemsinRoom; set => itemsinRoom = value; }


        public Room() {
            exitsInRoom = new List<string>();
            itemsinRoom = new List<string>();
        }

        public Room(string incomingData, string incomingDesc) {
            exitsInRoom = new List<string>();
            itemsinRoom = new List<string>();
            AssignRoomDetails(incomingData, incomingDesc);
            
        }



        public void AssignRoomDetails(string nextRoomData, string nextDesc) {
            string[] data = nextRoomData.Split(',');
            //string[] desc = nextDesc.Split(',');
            
            LocX = Int32.Parse(data[0]);
            LocY = Int32.Parse(data[1]);
            for (int i = 2; i < data.Length; i++) {
                exitsInRoom.Add(data[i]);
                
            }
            description = nextDesc;
            
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
            string display = "\n     Possible Exits are: ";
            foreach(string exit in exitsInRoom) {
                exitsString += "  " + exit;
            }
            return "\n" + display + exitsString;
        }

        private string GetLocation() {
            return "\nWe are in room " + LocX + " , " + LocY;

        }
        
        public void DescribeRoom() {
            string desc = "";
            desc +=("\nDescription for room " + LocX + " " + LocY + "\n");

            desc +=("\n" + description);
            //Console.WriteLine(desc.ToString());
            DisplayText.FormatToScreen(desc);
            //Console.SetCursorPosition(5, 15);
            Console.WriteLine(GetExits());
        }



    }
}
