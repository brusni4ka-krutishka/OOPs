using System;

namespace Lab9
{
    public delegate void Attack();
    public delegate void Heal();
    public delegate void Apocalypse();
    public delegate void BeChange(string str);
    class Program
    {
        static void Main()
        {
            Game game = new();

            Сharacter char1 = new("Орк", 100, 15),
                char2 = new("Эльф", 120, 10);


            char1.NewCharacter();
            char1.RegChange((str) => Console.WriteLine(str));
            char1.NewCharacter();
            
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
            //////////////////////////////////////

            /*string str1 = "Hello! My name is Nastya";

            Console.WriteLine($"Делаем все буквы строчными\n{ChangeString.MyToLower(str1)}\n");
            Console.WriteLine($"Добавляем в конце букву g\n{ChangeString.AddLetter(str1, 'g')}\n");
            Console.WriteLine($"Меняем e на E\n{ChangeString.Ii(str1)}\n");
            Console.WriteLine($"Делаем все буквы заглавными\n{ChangeString.MyToUpper(str1)}\n");
*/
            string slovo1 = "Hello world ";
            string slovo2 = "How are you?";

            Action<string> del;
            del = (string str1) =>  Console.WriteLine($"Удаление: {str1 = str1.Remove(0, 1)}");
            Del(slovo1, del);

            Action<string, string> con;
            con = (string str1, string str2) => Console.WriteLine($"Конкантенация: {str1 = str1 + str2}");
            Con(slovo1, slovo2, con);

            Action<string> mut;
            mut = (string str1) =>Console.WriteLine($"Замена l на L: {str1 = str1.Replace("l", "L")}");
            Mut(slovo1, mut);

            Action<string> toUpper;
            toUpper = (string str1) => Console.WriteLine($"В верхнем регистре: {str1 = str1.ToUpper()}");
            ToUpper(slovo1, toUpper);

            Action<string> toLower;
            toLower = (string str1) => Console.WriteLine($"В нижнем регистре: {str1 = str1.ToLower()}");
            ToLower(slovo1, toLower);

            static void Con(string slovo1, string slovo2, Action<string, string> con) => con(slovo1, slovo2);
            static void Del(string slovo, Action<string> del) => del(slovo);
            static void Mut(string slovo, Action<string> mut) => mut(slovo);
            static void ToUpper(string slovo, Action<string> toUpper) => toUpper(slovo);
            static void ToLower(string slovo, Action<string> toLower) => toLower(slovo);

        
        Console.ReadKey();
        }
    }
}
