using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class Game {
        public static Player Player = new Player();
        public static Room currentRoom = new Room("1,1,left,down", "1,1,A single light swings back and forth, and you hear a subtle hum in the background","Nothing You can See"); // Place the player in the starting room
        
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

                //Console.SetCursorPosition(5, 20);
                Console.WriteLine("\n     Enter a command...: ");
                
                //Console.SetCursorPosition(5, 23);
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") {
                    Console.WriteLine("\n          Thanks for playing");
                    Console.ReadKey();
                    break;
                }


                isValid = parseCMD.Validate(input);
                if (isValid) {
                    
                    executeCmd.ProcessCmd(input);
                }
                else {
                    Console.WriteLine("\n    Sorry, Command " + input.ToUpper() + " is not recognized. Try again");
                    Console.ReadKey();
                }
                
            }
        }


    }

  
}
