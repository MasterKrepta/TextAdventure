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

        public Room AssignCurrentRoom(Room roomWeWant) {

            Console.WriteLine("\nRoom We want details: " + roomWeWant.locX + " " + roomWeWant.locY + " : Old exits are " + roomWeWant.possibleExits);

            for (int i = 0; i < Level.Count; i++) {
                if (roomWeWant.locX == Level[i].locX && roomWeWant.locY == Level[i].locY) {
                    Console.WriteLine("\nLevel has Exits: " + Level[i].possibleExits +" in array location: " + i);
                    roomWeWant = Level[i];
                    //roomWeWant.locX = Level[i].locX;
                    //roomWeWant.locY = Level[i].locY;
                    //roomWeWant.possibleExits = Level[i].possibleExits;
                    Console.WriteLine("new room  exits: " + roomWeWant.possibleExits);
                    break;
                }
                Console.WriteLine(i);

            }
            return roomWeWant;
        }

        
    }
    
}
