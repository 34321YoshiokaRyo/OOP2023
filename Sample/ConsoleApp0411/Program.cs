using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            string[] stringmoney = {"一万円札","五千円札","二千円札","千円札","五百円玉","百円玉", "五十円玉","十円玉","五円玉","一円玉"};
            int[] moneyInteger = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };

            Console.Write("金額:");
            int amount = int.Parse(Console.ReadLine());
            Console.Write("支払い:");
            int pay = int.Parse(Console.ReadLine());
            int change = amount - pay;
            Console.WriteLine("お釣" + change + "円");

            for (int i = 0; i < stringmoney.Length; i++)
            {
                //    Console.WriteLine(stringmoney[i] + ":" + change / moneyInteger[i]);
                Console.Write(stringmoney[i] + ":");
                astOut(change/moneyInteger[i]);  
                  change %= moneyInteger[i];
            }
        }

        //アスタリスク
        private static void astOut(int cnt) {
            for (int i = 0; i < cnt; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
