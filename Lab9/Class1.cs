using System;


namespace Lab9
{
    class Game
    {
        public event Attack Attacking;
        public event Heal Healing;
        public event Apocalypse Apocalypsing;
        public void DidAttack()
        {
            Console.WriteLine("Проверяем здоровье персонажей...");
            Attacking?.Invoke();
        }
        public void DidHealing()
        {
            Console.WriteLine("Проверяем здоровье персонажей...");
            Healing?.Invoke();
        }
        public void DidApocalypse()
        {
            Console.WriteLine("Это конец...");
            Apocalypsing?.Invoke();
        }

    }

    class Сharacter
    {
        public int changeCounter = 0;
        
        BeChange change;

        public void RegChange(BeChange change)
        {
            this.change=change;
        }

        public string Race { get; set; }
        public short Health { get; set; }
        public short Damage { get; set; }

        public Сharacter(string race, short health, short damage)
        {
            Race = race;
            Health = health;
            Damage = damage;
        }
        public void NewCharacter()
        {
            changeCounter++;
            Console.WriteLine("Добавлен персонаж");
            change?.Invoke($"Кол-во персонажей: {changeCounter}\n");
        }

        public void Attack()
        {
            if (Health > 0)
            {
                Health -= 10;
                Console.WriteLine($"Персонаж атакован!\nЗдоровье персонажа {Race}: {Health}\n");
            }else
            Console.WriteLine("Персонаж мертв.\n");
        }

        public void Heal()
        {
            if (Health > 0)
            {
                Health += 20;
                Console.WriteLine($"Персонаж подлечен.\nЗдоровье персонажа {Race}: {Health}\n");
            }
            else
                Console.WriteLine("Персонаж мертв.\n");
        }

        public void Apocalypse()
        {
            Health = 0;
            Console.WriteLine($"На персонажа {Race} упал метеорит.\nПерсонаж мертв.\n");
        }
    }
}
