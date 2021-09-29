using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool var_bool = true;
            byte var_byte = 234;
            sbyte var_sbyte = -120;
            char var_char = 'c';
            decimal var_demical = 9517m;
            double var_double = 1.678;
            float var_float = 1.2f;
            int var_int = -54;
            uint var_uint = 54;
            long var_long = 54654847;
            ulong var_ulong = 9865435465;
            short var_short = -30000;
            ushort var_ushort = 30000;
        

            //встроенные ссылочные типы
            object ref_object = 3u;
            string ref_string = "String";
            dynamic ref_dynamic = 1;
            Console.WriteLine($"{var_bool}, {var_double}, {var_short}");
            Console.WriteLine("Введите строку : "); ref_string = Console.ReadLine(); Console.WriteLine(ref_string);

            //1b
            var_long = var_uint; var_int = var_short; var_uint = var_ushort; var_double = var_float; var_ulong = var_ushort;
            var_int = (int)var_sbyte; var_double = (double)var_float; var_long = (long)var_ulong; var_ushort = (ushort)var_uint;
            bool convert_bool = Convert.ToBoolean(2);

            //1c
            byte num = 1;
            object obj = num;
            num = (byte)obj;

            //1d
            var variable = 123; num = (byte)variable;

            //1e
            Nullable<uint> zero = null;
            Console.WriteLine(zero);

            //1f
            /*var err = 0;
             * err = 1.23f; // нет преобразования*/

            //2a

            char ch1 = 's', ch2 = 's';
            if (ch1 == ch2)
                Console.WriteLine("Литералы равны");

            //2b

            string str1 = "first", copystr, str2 = "second", str3 = "third", str4 = "Привет, Мир";
            Console.WriteLine($"Сцепление : {str1 + str3}");
            copystr = String.Copy(str2);
            Console.WriteLine($"Копия строки {copystr}");
            Console.WriteLine(str2.Insert(3, str3));
            Console.WriteLine(str1.Substring(4));
            string[] splitstr = str4.Split(' ');
            Console.WriteLine($"{splitstr[0]}, {splitstr[1]}");

            //2c
            string nul = null, empt = "";
            Console.WriteLine("Null or Empty: ");
            Console.WriteLine(string.IsNullOrEmpty(null));
            Console.WriteLine(string.IsNullOrEmpty(empt));
            Console.WriteLine(string.IsNullOrEmpty(copystr));

            //2d
            StringBuilder newstr = new StringBuilder("Hi! I'm Nastya");
            Console.WriteLine(newstr.Remove(2, 4));
            Console.WriteLine(newstr.Insert(2, " ----"));

            //3a
            byte[,] matrix = { { 1, 2, 3 }, { 3, 4, 3 }, { 5, 6, 3 } };
            Console.WriteLine("Матрица: ");
            for (byte i = 0; i < matrix.GetLength(0); i++)
            {
                for (byte j = 0; j < matrix.GetUpperBound(0) + 1; j++)
                {
                    Console.WriteLine($"{matrix[i, j]}\t");

                };
                Console.WriteLine();
            };

            //3b
            string[] days = { "Mon", "Tue", "Wed", "Thi", "Fri", "Sat", "Sun" };
            Console.Write($"Длинна массива days: {days.Length}\n");
            for (byte i = 0; i < days.Length; i++)
                Console.Write("Day[{0}]= {1}; ", i + 1, days[i]);
            Console.WriteLine();

            //3c
            byte[][] nums = new byte[3][];
            nums[0] = new byte[2] { 1, 2 };
            nums[1] = new byte[3] { 1, 2, 3 };
            nums[2] = new byte[4] { 1, 2, 3, 4 };

            //3d
            var notT = new[] { 1, 2, 3, 4 };

            //4a
            (int, string, char, string, ulong) kort = (1, "Peace", 'a', "Death", 351);

            //4b
            Console.WriteLine($"\nКортеж целиком: {kort}");
            Console.WriteLine($"Частично: {kort.Item2}, {kort.Item4}");

            //4c
            int r1; string r2, r4;char r3; ulong r5;
            (r1, r2, r3, r4, r5) = kort;
            Console.WriteLine(r2);

            //4d
            (int, string, char, string, ulong) kort_2 = (1, "hello", 'b', "world", 123);
            var z = (kort == kort_2) ? "Кортежи равны" : "Кортежи не равны";
            Console.WriteLine(z);

            //5
            (byte, byte, byte, char) localfunction (int[] mass, string str)
            {
                byte max = (byte)mass.Max(),
                    min = (byte)mass.Min(),
                    sum = (byte)mass.Sum();
                char firstsymb = str.First();
                return (max, min, sum, firstsymb);
            }
            int[] massive = { 1, 4, 2, 6, 7 };
            string strin = "Hell";
            Console.WriteLine("\nЛокальная функция: ");
            Console.WriteLine(localfunction(massive, strin));

            //6
            int func_checked()
            {
                checked
                {
                    int q = int.MaxValue; 
                    try
                    {
                        return q + 1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Переполнение");
                        return q;
                    }

                }
            }

            int func_unchecked()
            {
                unchecked
                {
                    int q = int.MaxValue;
                    try
                    {
                        return q + 1;
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Переполнение");
                        return q;
                    }
                }
            }
            Console.WriteLine(func_checked());
            Console.WriteLine(func_unchecked());

            Console.ReadKey();
        }
    }
}

