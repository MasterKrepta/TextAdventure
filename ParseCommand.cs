using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    class ParseCommand {
        PossibleCommands validCmds = new PossibleCommands();
        private string _cmdInput;

        public string CmdInput { get => _cmdInput; set => _cmdInput = value;}

        public bool Validate(string input) {
            CmdInput = input;
            if (validCmds.validCommands.Contains(CmdInput.ToLower())){
                return true;
            }
            else {
                return false;
            }
        }
    }
}
