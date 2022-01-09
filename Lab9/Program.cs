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

            string str1 = "Hello! My name is Eugene";

            Console.WriteLine($"Делаем все буквы строчными\n{ChangeString.MyToLower(str1)}\n");
            Console.WriteLine($"Добавляем в конце букву g\n{ChangeString.AddLetter(str1, 'g')}\n");
            Console.WriteLine($"Меняем e на E\n{ChangeString.Ii(str1)}\n");
            Console.WriteLine($"Делаем все буквы заглавными\n{ChangeString.MyToUpper(str1)}\n");

            Console.ReadKey();
        }
    }
}
