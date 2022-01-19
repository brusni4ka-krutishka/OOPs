using System;

namespace Lab8
{
    class Program
    {
        static void Main()
        {
            Train[] Trains = new Train[4];
            for (byte i = 0; i < 4; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й номер поезда:");
                Trains[i] = new();
                Trains[i].TrainNum = Console.ReadLine();
            }
            Console.WriteLine("--------------------------------------------------------");

            CollectionType<Train> myCollection = new();
            for (byte i = 0; i < 4; i++)
            {
                myCollection.MyAdd(Trains[i]);
            }
            myCollection.Check();
            Console.WriteLine("--------------------------------------------------------");

            bool[] exepts = new bool[2] { false, false };

            try
            {
                Train giveMe = myCollection.Delete(2);
                Console.WriteLine($"Извлечённый номер поезда {giveMe.TrainNum}");
                myCollection.Check();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.Source);
                exepts[0] = true;
            }
            finally
            {
                Console.WriteLine(exepts[0] == true ? "Исключение обработано" : "Исключение не обработано либо не произошло");
            }
            Console.WriteLine("--------------------------------------------------------");

            try
            {
                StandartTypes<int, double, byte> myTypes = new(1234, 123.4, 8); // обобщение для проверки типов
                myTypes.ShowTypes();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.Source);
                exepts[1] = true;
            }
            finally
            {
                Console.WriteLine(exepts[1] == true ? "Исключение обработано" : "Исключение не обработано либо не произошло");
            }
            Console.WriteLine("--------------------------------------------------------");

            myCollection.WriteToFile();
            myCollection.ReadFromFile();
            Console.ReadKey();
        }
    }
}
