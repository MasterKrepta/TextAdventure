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

        public Room(string incomingData, string incomingDesc, string itemsInRoom) {
            exitsInRoom = new List<string>();
            itemsinRoom = new List<string>();
            AssignRoomDetails(incomingData, incomingDesc, itemsInRoom);
            
        }



        public void AssignRoomDetails(string nextRoomData, string nextDesc, string nextItem) {
            string[] data = nextRoomData.Split(',');
            //string[] desc = nextDesc.Split(',');
            string[] items = nextItem.Split(',');
            LocX = Int32.Parse(data[0]);
            LocY = Int32.Parse(data[1]);
            for (int i = 2; i < data.Length; i++) {
                exitsInRoom.Add(data[i]);
                
            }
            description = nextDesc;
            foreach(string item in items){
                AddItems(item);
            }   
            
            
        }


        public void AddExit(string exit) {
            if (!exitsInRoom.Contains(exit)) {
                exitsInRoom.Add(exit);
            }

        }

        public void RemoveExit(string exit) {
            if (exitsInRoom.Contains(exit)) {
                exitsInRoom.Remove(exit);
            }
        }
        public bool CanExit(string dir) {
            foreach(string valid in exitsInRoom) {
                if (dir == valid) {
                    return true;
                }
            }
            return false;
        }       


        private void AddItems(string item) {
            itemsinRoom.Add(item);
        }

        private string GetExits() {
            string exitsString = "";
            string display = "\n     Possible Exits are: ";
            foreach(string exit in exitsInRoom) {
                exitsString += "  " + exit;
            }
            return "\n" + display + exitsString;
        }

        private string GetItems() {
            string itemString = "";
            string display = "\n     Items in room: ";
            foreach (string item in ItemsinRoom) {
                itemString += " " + item;
            }
            return "\n" + display + itemString;
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
            Console.WriteLine(GetItems());
        }



    }
}
