using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            // var flowerDict = new Dictionary<string, int>() {
            //     ["sunflower"] = 400,
            //     ["punsy"] = 300,
            //      ["tulip"] = 350,
            //     ["rose"] = 500,
            //     ["dahlia"] = 450,
            // };

            //morning glory(あさがお)【250円】を追加
            // flowerDict["morning glory"] = 250;

            // Console.WriteLine("ひまわりの価格は{0}円です", flowerDict["sunflower"]);
            // Console.WriteLine("チューリップの価格は{0}円です", flowerDict["tulip"]);
            // Console.WriteLine("あさがおの価格は{0}円です", flowerDict["morning glory"]);

            Console.WriteLine("県庁所在地の登録");

            var prefDict = new Dictionary<string, string>() {

            };
            Console.Write("県名：");
            var prefecture = Console.ReadLine();
            do {
                Console.Write("県庁所在地：");
                var city = Console.ReadLine();
                prefDict[prefecture] = city;
                Console.Write("県名：");
                prefecture = Console.ReadLine();
            } while (prefecture != "999");

            Console.Write("県名入力：");
            var str = Console.ReadLine();
            Console.WriteLine(prefDict[str] + "です");
        }
    }
}
