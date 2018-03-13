using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
     class Player {

    

        private  int posX;
        private  int posY;
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }

        private  List<Item> inventory;

        internal  List<Item> Inventory { get => inventory; set => inventory = value; }

        public Player() {
            posX = 1;
            posY = 1;
        }

        public  void Move(string dir) {

            Room room = GetCurrentRoom();

            if (!room.CanExit(dir)){
                Console.WriteLine("You cannot move that way!!");
                return;
            }
            switch (dir) {
                case "up":
                    PosY++; // or -- ???
                    break;
                case "down":
                    PosY--; // or -- ???
                    break;
                case "left":
                    PosX--; // or -- ???
                    break;
                case "right":
                    PosX++; // or -- ???
                    break;
            }
            
        }

        public  Room GetCurrentRoom() {
            return Game.currentRoom;
        }

        public void ChangeLocation() {
            foreach (Room room in Game.World.Level) {
                if (posX == room.LocX && posY == room.LocY) {
                    Game.currentRoom = room;
                    break;
                }
            }
        }
    }
}

