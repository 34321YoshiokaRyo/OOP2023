using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    
    class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            //インスタンスの作成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine(karinto.GetPriceIncludingTax());
            //Console.WriteLine(daifuku .GetPriceIncludingTax());
            #endregion

            #region 演習１
            DateTime date = DateTime.Today;

            //１０日後を求める
            DateTime daysAfter10 = date.AddDays(10);

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);

            Console.WriteLine("今日の日付：" + date.Year + "月" + date.Month + "月" + date.Day + "日");
            Console.WriteLine("10日後：" + daysAfter10.Year + "月" + daysAfter10.Month + "月" + daysAfter10.Day + "日");
            Console.WriteLine("10日前：" + daysBefore10.Year + "月" + daysBefore10.Month + "月" + daysBefore10.Day + "日");
            #endregion

            #region 演習２
            Console.WriteLine("誕生日を入力");
            Console.Write("西暦：");
            string year = Console.ReadLine();
            Console.Write("月：");
            string month = Console.ReadLine();
            Console.Write("日：");
            string day = Console.ReadLine();

            DateTime birth = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            TimeSpan interval = date - birth;

            Console.WriteLine("あなたは生まれてから今日まで" + interval.Days + "日目です。");
            #endregion

            #region 演習３
            string[] weeks = { "日", "月", "火", "水", "木", "金", "土" };
            Console.WriteLine(weeks[(int)birth.DayOfWeek] + "曜日");
            #endregion
        }
    }
}
