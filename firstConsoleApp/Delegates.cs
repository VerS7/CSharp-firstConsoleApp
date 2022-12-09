using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstConsoleApp
{
    delegate void WiseMessage(string wise);
    public class WiseTree
    {
        public static readonly string[] wises = new string[7] 
        {
            "[1] Волк никогда не будет жить в загоне, но загоны всегда будут жить в волке.",
            "[2] Лучше быть последним – первым, чем первым – последним.",
            "[3] Лев, может, и король джунглей, но волк в цирке не выступает.",
            "[4] Волк не тот кто охотиться один, а тот кто охотиться два.",
            "[5] Сколько волка не корми – овцы целее не будут.",
            "[6] Волк чужого не ищет. Волк довольствуется своим!",
            "[7] Кем бы ты ни был, кем бы ты не стал, помни, где ты был и кем ты стал."
        };
        public static void WisesHandler() 
        {
            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            WiseMessage mes = SendWise;
            foreach (string wise in wises) 
            {
                if (Array.IndexOf(wises, wise)+1 == dayOfWeek)
                {
                    mes(wise);
                }
            }
        }
        public static void SendWise(string wise) 
        {
            Console.WriteLine(wise);
        }
    }
    class Account 
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;
        public void RegisterHandler(AccountStateHandler del) 
        {
            _del = del;
        }
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del;
        }
        public int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum { get { return _sum; } }
        public void Put(int sum) 
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            if (sum < _sum)
            {
                _sum -= sum;
                _del?.Invoke($"Сумма {sum} снята со счёта.");
            }
            else
            {
                if (_del != null) _del?.Invoke("Недостаточно денег на счёте.");
            }
        }
        public static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
        public static void Color_Message(string message)
        {
            if (message.Contains("Недостаточно денег"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}
