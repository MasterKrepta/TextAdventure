using System;

namespace TextAdventure {
    class ExecuteCmd {
        PossibleCommands possibleCMDs = new PossibleCommands();

        public void ProcessCmd(string cmd) {
            
            switch (cmd.ToLower()) {
                //TODO clean up movement code
                case "up":
                    Game.Player.Move(cmd.ToLower());
                    break;
                case "down":
                    Game.Player.Move(cmd.ToLower());
                    break;
                case "left":
                    Game.Player.Move(cmd.ToLower());
                    break;
                case "right":
                    Game.Player.Move(cmd.ToLower());
                    break;
                case "drop":
                    if(Game.Player.Inventory.Count > 0) {
                        DropItem();
                    }
                    else {
                        Console.WriteLine("\n     You have nothing to drop!");
                        Console.ReadKey();
                    }
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
               
            }
        }


        private void DropItem() {
            
            Console.WriteLine("\nWhat do you want to Drop? : ");
            string itemToDrop = Console.ReadLine();
            if (Game.Player.Inventory.Contains(itemToDrop)) {
                Game.currentRoom.ItemsinRoom.Add(itemToDrop);
                Game.Player.Inventory.Remove(itemToDrop);
                Console.WriteLine("\nYou No longer need  the " + itemToDrop.ToUpper() + ", So you throw it on the ground!");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("\nThere is no" + itemToDrop.ToUpper() + " in your bag.");
                Console.ReadKey();
            }
        }

        private void CheckInventory() {
            Console.WriteLine("\nContents of inventory");
            Console.WriteLine("\n----------------------------");
            if (Game.Player.Inventory.Count == 0) {
                Console.WriteLine("INVENTORY IS EMPTY");
            }
            foreach (string item in Game.Player.Inventory) {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("\n----------------------------");
            Console.ReadKey();
        }

        private void Pickup() {
            Console.WriteLine("\nWhat do you want to pickup? : ");
            string itemToPickup = Console.ReadLine();
            if (Game.currentRoom.ItemsinRoom.Contains(itemToPickup)) {
                Game.Player.Inventory.Add(itemToPickup);
                Game.currentRoom.ItemsinRoom.Remove(itemToPickup);
                Console.WriteLine("\nYou place the " + itemToPickup.ToUpper() + " in your bag.");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("\nThere is no" + itemToPickup.ToUpper() + " in the room.");
                Console.ReadKey();
            }

        }

        private void Map() {
            ShowMap map = new ShowMap();
        }

        private void Help() {
            Console.Clear();
            string help = "\nEnter One of the following commands ";
            help += "\n_____________________________________";
            for (int i = 0; i < possibleCMDs.validCommands.Count; i++) {
                help += "\n" + possibleCMDs.validCommands[i];
            }
            help += "\n\nPress Enter to return to the game";
            DisplayText.FormatToScreen(help);
            Console.ReadKey();
        }

        private void Use() {
            Console.WriteLine("\nWhat do you want to use? : ");
            string itemToUse = Console.ReadLine();
            if(Game.currentRoom.ItemsinRoom.Contains(itemToUse.ToLower()) || Game.Player.Inventory.Contains(itemToUse.ToLower())) {
                Rules.CanUse(itemToUse.ToLower());
                Console.ReadKey();
            }
            else {
                Console.WriteLine("\nThere is no " + itemToUse.ToUpper() + " available.");
                Console.ReadKey();
            }

        }

        private void Look(Room currentRoom) {
            Console.WriteLine("\nContents of room");
            Console.WriteLine("\n----------------------------");
            if (currentRoom.ItemsinRoom.Count == 0) {
                Console.WriteLine("ROOM IS EMPTY");
            }
            foreach (string item in currentRoom.ItemsinRoom) {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("\n----------------------------");
            Console.ReadKey();
            

        }
        
    }
}
