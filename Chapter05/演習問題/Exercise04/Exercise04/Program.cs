using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            //    var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            //    var replaced = line.Replace("Novelist", "作家").Replace("BestWork","代表作").Replace("Born","誕生年");
            //    var words = replaced.Split(';','=');

            //    Console.WriteLine(words[0] + "  : " + words[1]);
            //    Console.WriteLine(words[2] + ": " + words[3]);
            //    Console.WriteLine(words[4] + ": " + words[5]);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1948",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1948",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1948",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",

            };

            foreach (var item in lines) {
                var replaced2 = item.Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born", "誕生年");
                var words2 = replaced2.Split(';', '=');

                Console.WriteLine(words2[0] + "  : " + words2[1]);
                Console.WriteLine(words2[2] + ": " + words2[3]);
                Console.WriteLine(words2[4] + ": " + words2[5]);
                Console.WriteLine();
            }

            Console.WriteLine("実行時間 = {0}", sw.Elapsed.ToString(@"ss\.fffff"));
        }
    }
}
