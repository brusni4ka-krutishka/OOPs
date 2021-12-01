using System;
using System.Collections.Generic;
namespace Lab4
{
    class Program
    {
        static void Main()
        {
/*-----------------------------------------------------------------------------------------------------------------------------------------------------*/
            List<int> li1 = new() { 1, 9, 2, 3 }, //Коллекция. Создается для того, чтобы заполнить экземляр класса
                li2 = new() { 7, 8, 9 }, //Сокращенная запись конструктора в .NET 5.0!
                li3 = new() { 70, 10, 9 };

            List list1 = new(li1), //Экземпляры класса
                list2 = new(li2),
                list3 = new(li3);

            Console.WriteLine("Исходный список: ");
            foreach (var item in li1)
                Console.Write(item + " ");

            Console.WriteLine("\nДобавление элемента с помощью \"+\"");
            li2 = list1 + 10;

            foreach (var item in li2)
                Console.Write(item + " ");

            Console.WriteLine("\nУдаление последнего с помощью \"--\"");
            list3--;

            foreach (var item in list3)
                Console.Write(item + " ");


            Console.WriteLine("\nПроверка на неравенство:");
            Console.WriteLine(list2!=list3);

            Console.WriteLine("\nПроверка на упорядоченность:");
            Console.WriteLine(list3?"ДА\n": "НЕТ\n");
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------*/
            List<string> strlist = new() { "Привет", "У", "меня", "Есть", null };//Статик оперейшн
            StatisticOperation.Counter(strlist);
            StatisticOperation.IsNULLHere(strlist);

            StatisticOperation.Sum(li1);
            StatisticOperation.Delta(li1);
            /*---------------------------------------------------------------------------------------*/
            Console.WriteLine();
            Owner owner = new(1780401, "Nastya", "BSTU");
            owner.GetInfo();
            /*---------------------------------------------------------------------------------------*/
            Console.WriteLine();
            Date date = new(12, 12, 2021);
            date.GetDate();
        }
    }
}
