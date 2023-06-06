using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var replaced = line.Replace("Novelist", "作家").Replace("BestWork","代表作").Replace("Born","誕生年");
            var words = replaced.Split(';','=');

            Console.WriteLine(words[0] + "  : " + words[1]);
            Console.WriteLine(words[2] + ": " + words[3]);
            Console.WriteLine(words[4] + ": " + words[5]);
        }
    }
}
