using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    public class PlayersList
    {
        private List<string> Players = new List<string>();

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
            Console.WriteLine($"Первый в очереди: {queue.First().Name}. Возраст - {queue.First().Age}");
            Console.WriteLine("Вся очередь:");
            foreach (Client elem in queue)
            {
                Console.WriteLine($"{elem.Name} | {elem.Age}");
            }
        }
        public void DequeueClient()
        {
            var dec = queue.Dequeue();
            Console.WriteLine($"Удалён клиент: {dec.Name}");
        }
    }
}
