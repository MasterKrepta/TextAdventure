using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* This class will parse the Text file that is our map, and store the data into a Map Object
 * 
 *
 */
namespace TextAdventure {
    class WorldBuilder {

        public string[] worldData = File.ReadAllLines(@"..\data\worldmap.txt");
        public List<Room> Level = new List<Room>();

        public WorldBuilder() {

            CreateRooms();
            Console.WriteLine("\nWorld created Press any key to exit.");
            Console.ReadKey();
            Console.Clear();
        }

     void CreateRooms() {
            for (int i = 0; i < worldData.Length; i++) {
                string nextRoom = worldData[i];
                Room newRoom = new Room(nextRoom);
                Level.Add(newRoom);
                Console.WriteLine("\nLevel contains " + Level.Count + " rooms");
                GetCurrentRoom();
            }

        }

        public Room GetCurrentRoom() {
            Room newRoom = Level[0];
            foreach (Room room in Level) {
                if(Game.currentRoom.locX == room.locX &&
                    Game.currentRoom.locY == room.locY) {
                    newRoom = room;
                }
            }
            return newRoom;
        }

    }
    
}
