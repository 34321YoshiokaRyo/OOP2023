﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            //{\rtf1}
        }

        private static void Exercise3_1(string text) {
            Console.Write("空白数：");
            Console.WriteLine(text.Where(c => c == ' ').Count());
        }

        private static void Exercise3_2(string text) {
           
        }

        private static void Exercise3_3(string text) {
            
        }

        private static void Exercise3_4(string text) {
            
        }

        private static void Exercise3_5(string text) {
           
        }
    }
}
