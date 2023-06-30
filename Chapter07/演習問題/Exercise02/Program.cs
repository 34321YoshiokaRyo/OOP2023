using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Abbreviations a = new Abbreviations();
            Console.WriteLine(a.Count);

            Console.Write("省略語：");
            var str = Console.ReadLine();
            a.Remove(str);
            Console.WriteLine(a.Count);

            a.Return();
        }
    }
}
