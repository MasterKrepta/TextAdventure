using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Game {
        
        public static Room currentRoom = new Room("1,1,left,down");
        public static WorldBuilder World = new WorldBuilder();
        

        static void Main(string[] args) {
            
            ParseCommand parseCMD = new ParseCommand();
            ExecuteCmd executeCmd = new ExecuteCmd();
            World.CreateRooms();
            World.AssignCurrentRoom(Game.currentRoom);
            

            while (true) {
                //TODO: set this up to read next part of story
                DescribeCurrentRoom();
                

                Console.WriteLine("\nEnter a command...: ");
                string input = Console.ReadLine();
                
                bool isValid = parseCMD.Validate(input);

                if(input.ToLower() == "exit") {
                    Console.WriteLine("\nThanks for playing");
                    Console.ReadKey();
                    break;
                }

                if (isValid) {
                    //Console.WriteLine(isValid + " : " + input.ToUpper());
                    executeCmd.ProcessCmd(input);
                }
                else {
                    Console.WriteLine("\nSorry, Command " + input.ToUpper() + " is not recognized. Try again");
                }
                Console.ReadKey();
            }
        }

        private static void DescribeCurrentRoom() {
            //TODO: FOR TESTING ONLY, Remove when Finished
            Console.Clear();
            Console.WriteLine("\nWe are currently in Room " + currentRoom.locX + " " + currentRoom.locY);


            currentRoom.DisplayRoomDescription();

            Console.WriteLine("\nPossible Exits are: " + currentRoom.possibleExits);
        }
    }

  
}
