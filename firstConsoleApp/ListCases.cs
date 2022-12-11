using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    public class PlayersList
    {
        private List<string> Players = new List<string>();
        public PlayersList()
        {
            PlayersHandler();
        }

        public void SendPlayers() 
        {
            Players.Sort();
            foreach (var player in Players)
            {
                Console.WriteLine(player);
            }
        }
        public void AddPlayer(string player)
        {
            Players.Add(player);
        }
        public char? GetCommand()
        {
            try
            {
                char cmnd = Convert.ToChar(Console.ReadLine());
                if (cmnd == '1' | cmnd == '2') 
                {
                    return cmnd;
                }
                return '3';
            }
            catch (Exception) { Console.WriteLine("Некорректная команда."); return null; }
        }
        public void PlayersHandler()
        {
            Console.WriteLine("Список игроков команды.");
            Console.WriteLine("1 - добавить. 2 - вывести всех игроков.");
            while (true)
            {
                switch (GetCommand())
                {
                    case '1':
                        Console.Write("Введите имя игрока:");
                        AddPlayer(Convert.ToString(Console.ReadLine()));
                        break;
                    case '2':
                        Console.WriteLine("Все игроки:");
                        SendPlayers();
                        break;
                    case '3':
                        Console.WriteLine("Некорректная команда!");
                        break;
                    case null:
                        Console.WriteLine("Произошла ошибка. Попробуй ещё раз.");
                        break;
                }
            }
        }
    }

    struct Client
    {
        public string Name;
        public byte Age;

        public Client(string Name, byte Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void WriteClient()
        {
            Console.WriteLine($"Клиент: {Name}. Возраст: {Age}");
        }
    }

    public class HRQueue
    {
        private Queue<Client> queue = new Queue<Client>();

        public HRQueue()
        {
            HRQueueHandler();
        }

        public void HRQueueHandler()
        {
            Console.WriteLine("Программа \"Очередь\".");
            Console.WriteLine("1 - добавить. 2 - продвинуть очередь. 3 - вывести очередь.");
            while (true)
            {
                switch (GetCommand())
                {
                    case '1':
                        Console.Write("Введите имя и возраст:");
                        var client = ParseClient();
                        AddClient(client.Key, client.Value); 
                        break;
                    case '2':
                        Console.WriteLine("Очередь продвинута.");
                        DequeueClient();
                        break;
                    case '3':
                        QueueInfo();
                        break;
                    case '4':
                        Console.WriteLine("Некорректная команда. Попробуйте ещё раз.");
                        break;
                }
            }
        }
        public KeyValuePair<string, byte> ParseClient()
        {
            try
            {
                string toparse = Convert.ToString(Console.ReadLine());
                KeyValuePair<string, byte> client = new KeyValuePair<string, byte>(toparse.Split(' ')[0], Convert.ToByte(toparse.Split(' ')[1]));
                return client;
            }
            catch (Exception) 
            {
                Console.WriteLine("Ошибка в передаче имени и возраста клиента.");
                return new KeyValuePair<string, byte>();
            }
        }
        public char? GetCommand()
        {
            try
            {
                char cmnd = Convert.ToChar(Console.ReadLine());
                if (cmnd == '1' | cmnd == '2' | cmnd == '3')
                {
                    return cmnd;
                }
                return '4';
            }
            catch (Exception) { Console.WriteLine("Некорректная команда."); return null; }
        }

        public void AddPlaceholderClients(int clients_count)
        {
            Random rand = new();
            for (int i = 0; i < clients_count; i++)
            {

                Client cl = new($"Клиент{i}", (byte)rand.Next(18, 65));
                queue.Enqueue(cl);
            }
        }
        public void AddClient(string Name, byte Age)
        {
            Client cl = new(Name, Age);
            queue.Enqueue(cl);
        }
        public void QueueInfo()
        {
            if (queue.Count != 0)
            {
                Console.WriteLine($"Первый в очереди: {queue.First().Name}. Возраст - {queue.First().Age}");
                Console.WriteLine("Вся очередь:");
                foreach (Client elem in queue)
                {
                    Console.WriteLine($"{elem.Name} | {elem.Age}");
                }
            }
            else
            {
                Console.WriteLine("Очередь пустая!");
            }
        }
        public void DequeueClient()
        {
            if (queue.Count != 0)
            {
                var dec = queue.Dequeue();
                Console.WriteLine($"Удалён клиент: {dec.Name}");
            }
            else
            {
                Console.WriteLine("Очередь пустая!");
            }
        }
    }
    struct Entrant
    {
        public string Name;
        public double Points;
        public Entrant(string Name, double points)
        {
            this.Name = Name;
            this.Points = points;
        }
    }
    class EntrantRegister
    {
        public EntrantRegister()
        {
            EntrantHandler();
        }
        private List<Entrant?> entrants = new();
        public void EntrantHandler()
        {
            Console.WriteLine("1 - Регистрация абитуриентов");
            Console.WriteLine("2 - Удаление забранных заявлений");
            Console.WriteLine("3 - Зачисление абитуриентов");
            bool appIsActive = true;
            while (appIsActive)
            {
                switch (GetCommand())
                {
                    case '1':
                        entrants.Add(RegisterParse());
                        SendInfo();
                        break;
                    case '2':
                        Unregister();
                        SendInfo();
                        break;
                    case '3':
                        Enrollment();
                        appIsActive = false;
                        break;
                    case '4':
                        Console.WriteLine("Некорректная команда!");
                        break;
                }
            }
        }
        public void Unregister()
        {
            try
            {
                Console.Write("Введите номер забравшего заявление абитуриента:");
                entrants.Remove(entrants[Convert.ToInt32(Console.ReadLine())-1]);
                SendInfo();
            }
            catch (Exception) { Console.WriteLine("Некорректный ввод."); }

        }
        public void SendInfo()
        {
            foreach (var item in entrants)
            {
                Console.WriteLine($"{entrants.IndexOf(item)+1}) {item.Value.Name} {item.Value.Points}");
            };
        }
        public void Enrollment() 
        {
            try
            {
                Console.Write("Введите пороговый балл:");
                double st = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Абитурианты на зачисление:");
                foreach (var item in entrants)
                {
                    if (item.Value.Points >= st)
                    {
                        Console.WriteLine($"{item.Value.Name} {item.Value.Points}");
                    }
                }
            }
            catch (Exception) { Console.WriteLine("Некорректный ввод."); }
        }
        public Entrant? RegisterParse()
        {
            try
            {
                Console.Write("Введите фамилию абитуриента:");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите средний балл:");
                double avg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{name} со средним баллом {avg} зарегистрирован!");
                return new Entrant(name, avg);
            }
            catch (Exception) { Console.WriteLine("Некорректный ввод."); return null; }
        }
        public static char? GetCommand()
        {
            try
            {
                char cmnd = Convert.ToChar(Console.ReadLine());
                if (cmnd == '1' | cmnd == '2' | cmnd == '3')
                {
                    return cmnd;
                }
                return '4';
            }
            catch (Exception) { Console.WriteLine("Некорректная команда."); return null; }
        }
    }
}
