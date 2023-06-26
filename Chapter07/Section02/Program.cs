using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var prefOfficeDict = new Dictionary<string, List<CityInfo>>();
            string pref, city;
            int population;

            Console.WriteLine("都市の登録");
            while (true) {
                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("市町村名：");
                city = Console.ReadLine();

                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());

                var cityinfo = new CityInfo {
                    City = city,
                    Population = population,
                };

                
                if (!prefOfficeDict.ContainsKey(pref)) {
                    prefOfficeDict[pref] = new List<CityInfo>();
                }
                prefOfficeDict[pref].Add(cityinfo);            
                
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                //一覧表示

                //foreach (var item in prefOfficeDict.OrderByDescending(p => p.Value)) {
                //    Console.WriteLine("{0}【{1}(人口：{2}人)】", item.Key, item.Value);
                //}

                foreach (var item in prefOfficeDict) {
                    foreach (var items in item.Value) {
                        Console.WriteLine("{0} 【{1} (人口:{2})】", item.Key,items.City,items.Population);
                    }
                }

            }
            else {
                //県名指定表示
                Console.Write("県名を入力：");
                var inputPref = Console.ReadLine();
                foreach (var item in prefOfficeDict[inputPref]) {
                    Console.WriteLine("{0} 【{1} (人口:{2})】",inputPref,item.City,item.Population);
                }
            }
        }
    }
}

class CityInfo {
    public string City { get; set; }
    public int Population { get; set; }
}