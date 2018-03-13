using System;

namespace TextAdventure {
    class ExecuteCmd {
        

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
               
            }
        }


        private void DropItem() {
           
        }

        private void CheckInventory() {
           
        }

        private void Pickup() {
            

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
            

        }


        
    }
}
