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
        public static Room[,] LevelGrid;
        public string[] worldData = File.ReadAllLines(@"..\data\worldmap.txt");
        public List<Room> Level = new List<Room>();

        public WorldBuilder() {

        }


    public void CreateRooms() {
            for (int i = 0; i < worldData.Length; i++) {
                string nextRoom = worldData[i];
                Room newRoom = new Room(nextRoom);
                Level.Add(newRoom);

            }
            //foreach (Room room in Level) {           
            //    Console.WriteLine(room.locX + " " + room.locY + " " + room.possibleExits);
            //}

             
            Console.WriteLine("\nWorld created Press any key to exit.");
            Console.ReadKey();
            Console.Clear();

    }

     public static void BuildLevel() {
            LevelGrid = new Room[5, 3];

            Room room;

            room = new Room();
            LevelGrid[0, 0] = room;
        }  

        
    }
    
}
