﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {

            var employee = new Employee {
                Id = 1000,
                Name = "AAAA",
                HireDate = new DateTime()
            };
            using (var writer = XmlWriter.Create(v)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }

            using (var reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employees = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employees);
            }
        }

        private static void Exercise1_2(string v) {

            var employee = new Employee[] {
                new Employee{
                    Id = 1,
                    Name = "aaaa",
                    HireDate = new DateTime()
                },
                new Employee{
                    Id = 2,
                    Name = "bbbb",
                    HireDate = new DateTime()
                },


            };
            var setting = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var writer = XmlWriter.Create(v, setting)) {
                var serializer = new DataContractSerializer(employee.GetType());
                serializer.WriteObject(writer, employee);
            }

        }

        private static void Exercise1_3(string v) {

            using (XmlReader reader = XmlReader.Create(v)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var employee = serializer.ReadObject(reader) as Employee[];
                foreach (var item in employee) {
                    Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.HireDate);
                }
            }
        }

        private static void Exercise1_4(string v) {
            var employees = new Employee2[] {
                new Employee2{
                    Name = "A",
                    HireDate = DateTime.Now,
                },
                new Employee2{
                    Name = "B",
                    HireDate = DateTime.Now,
                },
            };
            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(employees.GetType());
                serializer.WriteObject(stream, employees);
            }
        }
    }

    [DataContract]
    public class Employee2 {
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "hireDate")]
        public DateTime HireDate { get; set; }
    }
}
