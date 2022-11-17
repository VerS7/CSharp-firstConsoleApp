using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace firstConsoleApp
{
    public class Visa
    {
        public string clientName = "Имя Не Указано";
        public long ident = 0;
        public double balance = 0;
        public Visa(string client, long ID, long balance)
        {
            this.clientName = client;
            this.ident = ID;
            this.balance = balance;
            Console.WriteLine("Создана Visa.");
        }
        public void info()
        {
            Console.WriteLine("Visa Standart.");
            Console.WriteLine($"ФИО клиента: {clientName}.");
            Console.WriteLine($"Номер счёта: {ident}");
            Console.WriteLine($"Текущий баланс: {balance}$");
        }
        public void add(long num)
        {
            if (num > 0) { balance += num; }
            Console.WriteLine($"{num}$ добавлены на счёт!");
        }
        public void take(long num)
        {
            if (balance < num)
            {
                Console.WriteLine("На карте недостаточно средств.");
                Console.WriteLine($"Текущий баланс: {balance}$");
            }
            if (balance >= num)
            {
                balance -= num;
                Console.WriteLine($"Вы успешно сняли с карты {num}$");
                Console.WriteLine($"Текущий баланс: {balance}$");
            }
        }
    }
    public class VisaPlus : Visa
    {
        private int maxOver = 1000;
        private double over = 1000;
        private double debt = 0;
        private double prc = 0.2;
        public VisaPlus(string client, long ID, long balance) : base(client, ID, balance)
        {
            this.clientName = client;
            this.ident = ID;
            this.balance = balance;
        }
        public new void info()
        {
            Console.WriteLine("Visa Plus.");
            Console.WriteLine($"ФИО клиента: {clientName}.");
            Console.WriteLine($"Номер счёта: {ident}");
            Console.WriteLine($"Текущий баланс: {balance}$");
            Console.WriteLine($"Текущий овердрафт: {over}");
            Console.WriteLine($"Текущий долг: {debt}$");
        }
        public string balanceInfo() 
        {
            return $"Текущий баланс: {balance}$. Текущий овердрафт: {over}$. Текущий долг: {debt}$";
        }
        public new void take(long num) 
        {
            double maxbalance = balance + over;
            if (maxbalance < num) 
            {
                Console.WriteLine("Недостаточно средств.");
                Console.WriteLine(balanceInfo());
            }
            if (maxbalance >= num)
            {
                if (balance > num)
                {
                    balance -= num;
                }
                if (balance < num)
                {
                    balance -= num;
                    over -= balance * -1;
                    debt += (maxOver - over) * (1 + prc);
                    balance = 0;
                }
                Console.WriteLine($"Вы успешно сняли с карты {num}$");
                Console.WriteLine(balanceInfo());
            }
            if (debt < 0) 
            {
                balance += debt * -1;
                debt = 0;
            }
            if (debt == 0) 
            {
                over = maxOver;
            }
        }
        public new void add(long num) 
        {
            if (debt == 0) 
            {
                balance += num;
                Console.WriteLine($"{num}$ Добавлены на ваш счёт!");
            }
            if (debt > 0) 
            {
                debt -= num;
                Console.WriteLine($"{num}$ Добавлены на ваш счёт!");
            }
            if (debt < 0) 
            {
                balance += debt * -1;
                debt = 0;
            }
            if (debt == 0) 
            {
                over = maxOver;
            }
            Console.WriteLine(balanceInfo());
        }
    }
}