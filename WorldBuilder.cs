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
            
            Room newRoom = roomWeWant;
            for (int i = 0; i < Level.Count; i++) {
                if (newRoom.locX == Level[i].locX &&  newRoom.locY == Level[i].locY) {
                    Console.WriteLine("we found it");
                    newRoom = Level[i];
                    //newRoom.AssignRoomDetails(newRoom.ToString());
                    Console.WriteLine("new room has exits: " + newRoom.possibleExits.ToString());
                    Console.WriteLine("New RoomX : " + newRoom.locX + " New RoomY : " + newRoom.locY);
                    break;
                }
                
            }
            Console.WriteLine("current room before we change it is: " + Game.currentRoom.locX + " " + Game.currentRoom.locY);
            return newRoom;
        }

        public Room GetCurrentRoomByLoc(string locaton) {
            Room newRoom = new Room();
            int[] roomToFind = new Int32[2];
            string[] data = locaton.Split(',');
            roomToFind[0] = Int32.Parse(data[0]);
            roomToFind[1] = Int32.Parse(data[1]);
            Console.WriteLine(newRoom.possibleExits);
            for (int i = 0; i < Level.Count; i++) {
                if (roomToFind[0] == Level[i].locX &&
                    roomToFind[1] == Level[i].locY) {
                    newRoom = Level[i];
                    Console.WriteLine( newRoom.possibleExits + "after asignment");
                    Console.WriteLine(newRoom.possibleExits.ToString());
                    Console.WriteLine("New RoomX : " + Level[i].locX + " New RoomY : " + Level[i].locY);
                    Console.WriteLine("\nGet current says Possible Exits are: " + newRoom.possibleExits);

                    break;
                }
                else {
                    Console.WriteLine("NO MATCHINING FOUND !!!!!!");

                }
            }
            Console.WriteLine("current room before we change it is: " + Game.currentRoom.locX + " " + Game.currentRoom.locY);
            return newRoom;

        }
    }
    
}
