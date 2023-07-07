using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);

        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            // 2019/1/15 19:48
            var str = dateTime.ToString("yyyy/M/d HH:mm");
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            // 2019年01月15日 19時48分32秒
            var str = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            // 平成31年 1月15日（火曜日）
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = dateTime.ToString("ggyy年 M月d日 (dddd)");
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {

        }
    }
}
