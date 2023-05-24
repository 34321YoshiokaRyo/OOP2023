using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Console.WriteLine("****Exercise2_1****");
            Exercise2_1(names);
            Console.WriteLine();
            Console.WriteLine("****Exercise2_2****");
            Exercise2_2(names);
            Console.WriteLine();
            Console.WriteLine("****Exercise2_3****");
            Exercise2_3(names);
            Console.WriteLine();
            Console.WriteLine("****Exercise2_4****");
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");

            var str = Console.ReadLine();
            while (str != " ") {
                var index = names.FindIndex(s => s == str);
                Console.WriteLine(index);
                str = Console.ReadLine();
            }
            
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.FindAll(s => s.Contains("o")).Count();
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var city = names.Where(s => s.Contains("o"));
            foreach (var n in city) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise2_4(List<string> names) {
            
        }
    }
}
