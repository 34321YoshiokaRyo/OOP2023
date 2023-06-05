using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("数字文字列：");
            var line = Console.ReadLine();
            int num;

            if (int.TryParse(line,out num)) {
                var str = string.Format("{0:#,0}", num);
                Console.WriteLine(str);
            }
        }
    }
}
