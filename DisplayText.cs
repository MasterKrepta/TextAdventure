using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure {
    static class DisplayText {
        static int maxLineLength = 80;


        public static void FormatToScreen(string message) {
            string result = "\n";
            string[] lines = message.Split('\n');
            foreach (string line in lines) {
                int length = 0;
                string[] words = line.Split(' ');

                foreach (string word in words) {
                    if(word.Length + length >= maxLineLength - 1) {
                        result += "\n     ";
                        length = 0;
                    }
                    result += word + " ";
                    length += word.Length + 1;
                }
                result += "\n     ";
            }
            
            Console.WriteLine(result);
            
        }
    }
}
