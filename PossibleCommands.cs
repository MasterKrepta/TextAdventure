using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {

    class PossibleCommands {

        public List<string> validCommands = new List<string>();
        private string[] cmds = {
            "up",
            "down",
            "left",
            "right",
            "inventory",
            "i",
            "examine",
            "look",
            "l",
            "pickup",
            "drop",
            "use",
            "help",
            "map",
            
        };

        public PossibleCommands() {
            foreach (string cmd in cmds) {
                validCommands.Add(cmd.ToLower());
            }
        }
    }
}
    

