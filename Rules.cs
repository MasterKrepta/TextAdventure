using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    static class  Rules {
        // room to bring red key to
        const int redRoomX = 1;
        const int redRoomY = 2;

        // room to bring blue key to
        const int blueRoomX = 2;
        const int blueRoomY = 1;

        // room to bring yellow key to
        const int yellowRoomX = 3;
        const int yellowRoomY = 1;

        //room containing password
        const int passwordRoomX = 3;
        const int passwordRoomY = 2;

        //Final room to bring password to
        const int commandRoomX = 0;
        const int commandRoomY = 1;
        public static bool CanUse(string item) {
            bool result = true; // for testing
            Room room = Game.currentRoom;
            switch (item) {
                case "red key":
                    if(room.LocX == redRoomX && room.LocY == redRoomY) {
                        room.AddExit("right");
                        Console.WriteLine("\n    The key unlocks the Red door");
                    }
                    else {
                        Console.WriteLine("\n     This doenst seem to be the room to use the " + item + " in.");
                    }
                    break;

                case "blue key":
                    if (room.LocX == blueRoomX && room.LocY == blueRoomY) {
                        room.AddExit("right");
                        Console.WriteLine("\n    The key unlocks the Blue door");
                    }
                    else {
                        Console.WriteLine("\n     This doenst seem to be the room to use the " + item + " in.");
                    }
                    break;
                case "yellow key":
                    if (room.LocX == yellowRoomX && room.LocY == yellowRoomY) {
                        room.AddExit("up");
                        Console.WriteLine("\n    The key unlocks the Yellow door");
                    }
                    else {
                        Console.WriteLine("\n     This doenst seem to be the room to use the " + item + " in.");
                    }
                    break;
            }
            return result;
        }
    }
}
