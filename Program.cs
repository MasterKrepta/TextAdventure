using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {

    class Program {
        
        
        static void Main(string[] args) {
            ParseCommand parseCMD = new ParseCommand();
            ExecuteCmd executeCmd = new ExecuteCmd();



            while (true) {
                //TODO: set this up to read next part of story
                Console.WriteLine("\nStory stuff will go here");

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


     
    }

  
}
