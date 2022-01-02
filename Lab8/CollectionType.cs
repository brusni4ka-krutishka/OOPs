using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
namespace Lab8
{
   
    public class Train { 
        public string color;
        public int n;
        public Train(string color, int n)
        {
            this.color = color;
            this.n = n;
        }

        public void Move()//переопределяем метод "движение" класса-родителя
        {
            Console.WriteLine("Поезд движется.");
        }
        public void TrainsCarriage() 
        {
            Console.WriteLine("Это некий поезд.");
        }
        public string ToString()
        {
            return base.ToString() + "Переопределение toString() выполнено.";
        }
        public void ShowTrain(int n, string col)
        {
            Console.WriteLine($"Поезд с номером {n} имеет {col} цвет!");
        }
    }
    public class CollectionType<Type> : IGeneric<Type> where Type : class
    {
        public List<Type> passwords = new();

        public void Add(Type item)
        {
            passwords.Add(item);
        }

        public Type Delete(int item)
        {
            Type value = passwords[item];
            passwords.RemoveAt(item);
            return value;
        }

        public void Check()
        {
            int count = 0;
            foreach (Type item in passwords)
            {
                count++;
                Console.WriteLine($"Элемент списка под номером {count}\nТип: {item.GetType()}\n");

            }
        }
        public void WriteToFile()
        {
            StreamWriter inFile = null;
            try
            {
                inFile = new StreamWriter("..//лаба8.txt", false, Encoding.Default);
                inFile.WriteLine("Этот текст добавлен в файл с помощью класса StreamWriter\nЛюблю записывать строки в файлы");
            }
            finally
            {
                inFile.Close();
            }
        }

        public void ReadFromFile()
        {
            StreamReader fromFile = null;
            try
            {
                fromFile = new StreamReader("..//лаба8.txt");
                int counter = 0;

                foreach (string str in File.ReadAllLines("..//лаба8.txt"))
                {
                    counter++;
                }
                string[] arr = new string[counter];
                for (int i = 0; i < counter; i++)
                {
                    arr[i] = fromFile.ReadLine();
                    Console.Write(arr[i] + "\n");
                }
            }
            finally
            {
                fromFile.Close();
            }
        }
    }
    public class StandartTypes<Type1, Type2, Type3>
    {
        Type1 A { get; set; }
        Type2 B { get; set; }
        Type3 C { get; set; }

        public StandartTypes(Type1 A, Type2 B, Type3 C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public void ShowTypes()
        {
            Console.WriteLine($"Первый тип {A.GetType()} со значением {A}");
            Console.WriteLine($"Второй тип {B.GetType()} со значением {B}");
            Console.WriteLine($"Третий тип {C.GetType()} со значением {C}");
        }
    }
}
