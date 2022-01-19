using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab10
{
    class Program
    {
        static void Reaction(object sender, NotifyCollectionChangedEventArgs e)=> Console.WriteLine("Collection changed: " + e.Action);

        static void Main()
        {
            Console.WriteLine("Задание 1");
            Student stud3, stud4;
            Student[] ArrStudents =
            {
                new Student("Андрей", "Борозда",19, 8),
                new Student("Евгений", "Гончаревич", 18, 5),
                stud3=new("Позняк", "Полина",19,9),
                stud4=new("Шкабров","Данила", 19, 6)
            };

            var StudentQ = new StudentQueue(ArrStudents);
            StudentQ.Show();

            Console.WriteLine();
            StudentQ.Add(new Student("Василиса", "Кашперко", 19, 9));
            StudentQ.RemoveFirst();
            StudentQ.Show();


            Console.WriteLine($"В очереди есть Позняк?: {StudentQ.Find(stud3)}");
            Console.WriteLine($"В очереди есть Шкабров?: {StudentQ.Find(stud4)}\n");

            Console.WriteLine("Очистить очередь... ");
            StudentQ.Clear();
            StudentQ.Show();

            Console.WriteLine("\nЗадание 2");

            Queue<int> q1 = new();
            q1.Enqueue(0);
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);

            for (byte i = 0; i < 3; i++)
            {
                q1.Dequeue();
            }
            foreach(var item in q1)
                Console.Write(item+ " ");

            var list2 = new List<int>(q1);

            foreach (int item in list2)
                Console.Write(item + " ");

            Console.WriteLine();

            static bool Func(int x)=> x > 0;

            Console.WriteLine(list2.Find(Func));
            Console.WriteLine(list2.FindIndex(0, Func));

            Console.WriteLine("\nЗадание 3");
            var obsColl = new ObservableCollection<Student>(); // 3

            obsColl.CollectionChanged += Reaction;
            obsColl.Add(stud3);
            obsColl.Add(stud4);
            obsColl.Remove(stud3);
            Console.ReadKey();
        }
    }
}
