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
        public string[] roomDescriptions = File.ReadAllLines(@"..\data\descriptions.txt");
        public string[] itemsInRoom = File.ReadAllLines(@"..\data\ItemsInRoom.txt");
        public List<Room> Level = new List<Room>();




    public void CreateRooms() {
            for (int i = 0; i < worldData.Length; i++) {
                string nextRoom = worldData[i];
                string nextDesc = roomDescriptions[i];
                string nextItem = itemsInRoom[i];
                Room newRoom = new Room(nextRoom, nextDesc, nextItem);
                Level.Add(newRoom);

            }
  
             
            Console.WriteLine("\nWorld created Press any key to exit.");
            Console.ReadKey();
            Console.Clear();

    }

  

        
    }
    
}
