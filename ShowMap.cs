using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventure {
    class ShowMap {
        public string[] mapData = File.ReadAllLines(@"..\data\map.txt");
        

        public ShowMap() {

            foreach (string map in mapData) {
                Console.WriteLine("\t" + map);
            }

            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
