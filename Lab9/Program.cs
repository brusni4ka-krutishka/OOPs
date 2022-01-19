using System;

namespace Lab9
{
 
    public delegate void BeChange(string str);
    class Program
    {
        static void Main()
        {
            Game game = new();

            Сharacter char1 = new("Орк", 100, 15),
                char2 = new("Эльф", 120, 10);

            char1.RegChange((str) => Console.WriteLine(str));
            char1.NewCharacter();
            char1.NewCharacter();
            char2.RegChange((str) => Console.WriteLine(str));
            char2.NewCharacter();
           
           

            game.Attacking += char1.Attack;
            game.Attacking += char2.Attack;
            game.Attacking += char2.Attack;
            game.Attacking += char2.Attack;

            game.DidAttack();

            game.Healing += char2.Heal;
            game.DidHealing();

            Console.WriteLine("Да начнётся апокалипсис!");
            game.Apocalypsing += char1.Apocalypse;
            game.Apocalypsing += char2.Apocalypse;
            game.DidApocalypse();
            Console.WriteLine("Конец игры!\n");
    

            string slovo1 = "Hello world ";
            string slovo2 = "How are you?";

            Action<string, string> con = (string str1, string str2) => Console.WriteLine($"Конкатенация: {str1 = str1 + str2}");
            Action<string> del = (string str1) =>  Console.WriteLine($"Удаление: {str1 = str1.Remove(0, 1)}");
            Action<string> mut = (string str1) =>Console.WriteLine($"Замена l на L: {str1 = str1.Replace("l", "L")}");
            Action<string> toUpper = (string str1) => Console.WriteLine($"В верхнем регистре: {str1 = str1.ToUpper()}");
            Action<string> toLower = (string str1) => Console.WriteLine($"В нижнем регистре: {str1 = str1.ToLower()}");

            static void Con(string slovo1, string slovo2, Action<string, string> con) => con(slovo1, slovo2);
            static void Del(string slovo, Action<string> del) => del?.Invoke(slovo);
            static void Mut(string slovo, Action<string> mut) => mut(slovo);
            static void ToUpper(string slovo, Action<string> toUpper) => toUpper(slovo);
            static void ToLower(string slovo, Action<string> toLower) => toLower(slovo);

            Del(slovo1, del);

            Con(slovo1, slovo2, con);

            Mut(slovo1, mut);

            ToUpper(slovo1, toUpper);

            ToLower(slovo1, toLower);

            
        
        Console.ReadKey();
        }
    }
}
