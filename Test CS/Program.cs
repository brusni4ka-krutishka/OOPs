using System;

namespace Test_CS
{
    public delegate void AccountHandler(string message); //создание делегата void c параметром

    public class Account
    {
        AccountHandler taken;// "Экземпляр" делегата
        public event AccountHandler Notify; //Событие, соотв. классу делегата (AccountHandler)
        private int sum;
        public Account(int sum) => this.sum = sum; //Конструктор класса Account
        public void RegisterHandler(AccountHandler del) => taken = del;//Метод, принимающий метод, для вызова делегатом
        
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                Notify?.Invoke("ПРоизошло Действие");
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
    class Program
    {

        static void PrintSimpleMessage(string message) => Console.WriteLine(message);
        static void Main()
        {
            // создаем банковский счет
            Account account = new(200),
                account2 = new(400);
            account.RegisterHandler(PrintSimpleMessage);// Добавляем в делегат ссылку на метод PrintSimpleMessage
            account2.RegisterHandler(PrintSimpleMessage);

            account.Notify += (string mes) => Console.WriteLine($"Объект 1: {mes}");
            account2.Notify += (string mes) => Console.WriteLine($"Объект 2: {mes}");

            // Два раза подряд пытаемся снять деньги
            account.Take(100);
            account.Take(150);

            account2.Take(150);
            account2.Take(150);
        }
    }
}
