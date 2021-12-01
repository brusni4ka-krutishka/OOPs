using System;
using System.Collections.Generic;
namespace Lab4
{

    public class Owner
    {
        readonly private int id;
        readonly private string name;
        readonly private string org;

        public Owner(int id, string name, string org)
        {
            this.id = id;
            this.name = name;
            this.org = org;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID:{0}\nИмя:{1}\nОрганизация:{2}", id, name, org);
        }
    }
    public class Date // класс Date
    {
        readonly private int day;
        readonly private int month;
        readonly private int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void GetDate()
        {
            Console.WriteLine("Год:{0}\nМесяц:{1}\nДень:{2}\n", year, month, day);
        }
    }
    static class StatisticOperation
    {
        public static void Sum(List<int> list)
        {
            int a = 0;
            foreach (var item in list)
            {
                a += item;
            }
            Console.WriteLine("Сумма элементов: "+a);
        }
        public static void Delta(List<int> list)
        {
            list.Sort();
            int a = list[^1],//Эквивалентно [list.Counter-1]
                b = list[0];
            Console.WriteLine("Разница между макс. и мин."+(a-b));
        }
        //Подсчёт уже есть

        public static void Counter(List<string> list)
        {
            Console.WriteLine($"Число слов в списке: {list.Count}");
        }
        public static void Counter(List<int> list)
        {
            Console.WriteLine($"Число слов в списке: {list.Count}");
        }
        public static void IsNULLHere(List<string> list)
        {
            bool flag = false;
            foreach (var item in list )
                if (item == null)
                    flag = !flag;
            Console.WriteLine(flag ? "Null Есть" : "Null Нету");
        }
        public static void IsNULLHere(List<int> list)
        {
            bool flag = false;
            foreach (var item in list)
                if (item == 0)
                    flag = !flag;
            Console.WriteLine(flag ? "0 Есть" : "0 Нету");
        }

    }
}
