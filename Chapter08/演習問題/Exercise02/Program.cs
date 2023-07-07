using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var today = DateTime.Today;
           
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                Console.Write(today.ToString("yyyy/M/d") + "の次週の" + dayofweek + ":");
                Console.WriteLine(NextWeek(today, (DayOfWeek)dayofweek));
            }
        }

            public static DateTime NextWeek(DateTime date, DayOfWeek DayOfWeek) {
            var nextweek = date.AddDays(7);
                var days = (int)DayOfWeek - (int)(date.DayOfWeek);
                return nextweek.AddDays(days);
            }
        
    }
}
