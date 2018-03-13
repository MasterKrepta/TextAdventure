using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Game {
        public static Player Player = new Player();
        public static Room currentRoom = new Room("1,1,left,down"); // Place the player in the starting room
        
        public static WorldBuilder World = new WorldBuilder();
        

        static void Main(string[] args) {
            
            
            ParseCommand parseCMD = new ParseCommand();
            ExecuteCmd executeCmd = new ExecuteCmd();
            World.CreateRooms();
            bool isValid = false;

            while (true) {
                Console.Clear();
                Player.ChangeLocation();
                //TODO: set this up to read next part of story
                currentRoom.DescribeRoom();

                Console.WriteLine("\nEnter a command...: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") {
                    Console.WriteLine("\nThanks for playing");
                    Console.ReadKey();
                    break;
                }


                isValid = parseCMD.Validate(input);
                if (isValid) {
                    
                    executeCmd.ProcessCmd(input);
                }
                else {
                    Console.WriteLine("\nSorry, Command " + input.ToUpper() + " is not recognized. Try again");
                }
                Console.ReadKey();
            }
        }


    }

  
}
