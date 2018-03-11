using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class ExecuteCmd {
        Inventory inventory = new Inventory();

        public void ProcessCmd(string cmd) {
            
            switch (cmd.ToLower()) {
                case "up":
                    Console.WriteLine("move up");
                    MoveUp(Game.currentRoom);
                    break;
                case "down":
                    Console.WriteLine("move down");
                    MoveDown(Game.currentRoom);
                    break;
                case "left":
                    Console.WriteLine("move left");
                    MoveLeft(Game.currentRoom);
                    break;
                case "right":
                    Console.WriteLine("move right");
                    MoveRight(Game.currentRoom);
                    break;
                case "drop":
                    
                    DropItem();
                    break;
                case "look":
                    Look(Game.currentRoom);
                    break;
                case "l":
                    Look(Game.currentRoom);
                    break;
                case "examine":
                    Look(Game.currentRoom);
                    break;
                case "use":
                    Use();
                    break;
                case "pickup":
                    Pickup();
                    break;
                case "help":
                    Help();
                    Console.WriteLine("Display help menu");
                    break;
                case "map":
                    Map();
                    break;
                case "inventory":
                    CheckInventory();
                    break;
                case "i":
                    CheckInventory();
                    break;
                case "current": // FOR DEBUGING
                    CurrentRoom();
                    break;
            }
        }

        private void CurrentRoom() {
            Console.WriteLine("\nWe are currently in Room " + Game.currentRoom.locX + " " + Game.currentRoom.locY);
        }

        private void DropItem() {
            Console.WriteLine("\nWhat do you want to drop? : ");
            string itemToDrop = Console.ReadLine();

            if (inventory.playerInventory.Contains(itemToDrop.ToLower())) {
                Console.WriteLine(itemToDrop + " is dropped in the room");
                inventory.playerInventory.Remove(itemToDrop);
                inventory.roomInventory.Add(itemToDrop);
            }
            else {
                Console.WriteLine("\n" + itemToDrop + " does not exist");
            }
        }

        private void CheckInventory() {
            Console.WriteLine("\nContents of inventory");
            Console.WriteLine("\n----------------------------");
            if(inventory.playerInventory.Count == 0) {
                Console.WriteLine("INVENTORY IS EMPTY");
            }
            foreach (string item in inventory.playerInventory) {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("\n----------------------------");
        }

        private void Pickup() {
            Console.WriteLine("\nWhat do you want to Pickup? : ");
            string itemToPickup = Console.ReadLine();

            if (inventory.roomInventory.Contains(itemToPickup.ToLower())) {
                Console.WriteLine(itemToPickup + " is picked up");
                inventory.playerInventory.Add(itemToPickup);
                inventory.roomInventory.Remove(itemToPickup);
                
            }
            else {
                Console.WriteLine("\n" + itemToPickup + " does not exist");
            }

        }

        private void Map() {
            ShowMap map = new ShowMap();
        }

        private void Help() {
            throw new NotImplementedException();
        }

        private void Use() {
            Console.WriteLine("\nWhat do you want to use? : ");
            string itemToUse = Console.ReadLine();
            
            if (inventory.playerInventory.Contains(itemToUse.ToLower()) ||
                inventory.roomInventory.Contains(itemToUse.ToLower())) {
                Console.WriteLine(itemToUse + " is being used");
                //TODO remove item from list if its consumable
            } else {
                Console.WriteLine("\n" + itemToUse + " does not exist");
            }
           
        }

        private void Look(Room currentRoom) {
            Console.WriteLine("\nContents of room");
            Console.WriteLine("\n----------------------------");
            if (inventory.roomInventory.Count == 0) {
                Console.WriteLine("ROOM IS EMPTY");
            }
            foreach (string item in inventory.roomInventory) {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("\n----------------------------");
            
        }

        private void MoveRight(Room currentRoom) {
            if (CanWeMoveHere(currentRoom, "right")) {
                Game.currentRoom.locX++;
            }
        }

        private void MoveLeft(Room currentRoom) {
            if (CanWeMoveHere(currentRoom, "left")) {
                Game.currentRoom.locX--;
            }
        }

        private void MoveDown(Room currentRoom) {
            if (CanWeMoveHere(currentRoom, "down")) {
                Game.currentRoom.locY--;
            }
        }

        private void MoveUp(Room currentRoom) {
            if (CanWeMoveHere(currentRoom, "up")) {
                Game.currentRoom.locY++;
            }
            
        }

        private bool CanWeMoveHere(Room currentRoom, string direction) {
            if (currentRoom.possibleExits.Contains(direction.ToLower())){
                //Console.WriteLine("\nwe can move ");
                return true;
            }
            else {
                //Console.WriteLine("\nCannot move here");
                return false;
            }
                
        }
    }
}
