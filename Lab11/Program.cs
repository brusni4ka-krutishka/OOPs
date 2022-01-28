using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab11
{
    class Program
    {
        static void Main()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("Введите количество символов, равное количеству символов в названии месяца");
            byte n = byte.Parse(Console.ReadLine());
            var Months1 = months.Where(m => m.Length == n);
            foreach (string item in Months1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Только летние и зимние месяцы");
            var Months2 = from m in months where m.StartsWith("J") || m.StartsWith("F") || m.StartsWith("Au") || m.StartsWith("D") select m;
            foreach (string item in Months2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("В алфавитном порядке:");
            var Months3 = months.OrderBy(s => s);
            foreach (string item in Months3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Месяцы с буквой \"u\" и длиной строки 4 и выше");
            var Months4 = months.Where(n1 => n1.Contains("u") && n1.Length >= 4);
            foreach (string item in Months4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Abiturient ab1 = new("Гончаревич", "Евгений", new byte[] { 1,3,5,2}),
            ab2 = new("Позняк", "Полина", new byte[] { 10, 9, 9, 7 }),
            ab3 = new("Борозда", "Андрей", new byte[] { 4, 5, 9, 8 }),
            ab4 = new("Андрусь", "Олег", new byte[] { 9, 5, 6, 5 }),
            ab5 = new("Хвалей", "Максим", new byte[] { 8, 9, 5, 6 }),
            ab6 = new("Павловский", "Егор", new byte[] { 1, 2,2,2 }),
            ab7 = new("Кулинкович", "Даниил", new byte[] { 8, 2, 8, 6 });

            List<Abiturient> lib = new();

            lib.Add(ab1);
            lib.Add(ab2);
            lib.Add(ab3);
            lib.Add(ab4);
            lib.Add(ab5);
            lib.Add(ab6);
            lib.Add(ab7);

            Console.WriteLine("Студенты с неудовлетворительными оценками: ");
            var lib1 = lib.Where(score => score.Average_score() < 4);
            foreach (var item in lib1)
            {
                Console.WriteLine(item.Name+" "+item.Lastname+". Средний балл: "+item.Average_score());
            }

            Console.WriteLine("\nСтуденты с суммой баллов выше заданной. Введите балл: ");
            byte n2 = byte.Parse(Console.ReadLine());
            var lib2 = lib.Where(score => score.Sum() > n2);
            foreach (var item in lib2)
            {
                Console.WriteLine(item.Name + " " + item.Lastname + ". Сумма баллов: " + item.Sum());
            }

            Console.WriteLine("\nСтуденты с 10-кой по матеше: ");
            var lib3 = lib.Where(score => score.Math() == 10);
            foreach (var item in lib3)
            {
                Console.WriteLine(item.Name + " " + item.Lastname + ". Балл: " + item.Math());
            }

            Console.WriteLine("\nСтуденты по алфавиту: ");
            var lib4 = lib.OrderBy(score => score.Lastname);
            foreach (var item in lib4)
            {
                Console.WriteLine(item.Name + " " + item.Lastname + ".");
            }

            Console.WriteLine("\n4 последних абитуриента с самой низкой успеваемостью: ");
            var lib5 = lib.OrderBy(score => score.Sum()).Take(4);
            foreach (var item in lib5)
            {
                Console.WriteLine(item.Name + " " + item.Lastname + ". Сумма: " +item.Sum());
            }

            Console.WriteLine("---------------------------------------------------");


            List<City> cities =new()
            {
                new City { Name = "Bergamo", Country = "Italy" },
                new City { Name = "Valencia", Country = "Spain" }
            };

            List<Citizen> players =new()
            {
                new Citizen { Name = "Luigi", City = "Bergamo"},
                new Citizen { Name = "Marco", City = "Bergamo"},
                new Citizen { Name = "Sergio", City = "Valencia"}
            };

            var result = players.Join(cities,
             p => p.City,
             t => t.Name,
             (p, t) => new { p.Name, p.City, t.Country });


            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.City} ({item.Country})");

            Console.ReadKey();

        }
    }
}
