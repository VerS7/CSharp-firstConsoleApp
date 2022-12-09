using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    public class Cases
    {
        public static void Case4()
        {
            try 
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{a}*{b}={a * b:f1}");
            }
            catch (FormatException e) { Console.WriteLine($"Произошла ошибка. Неверный формат ввода // {e.Message}"); }
        }
    }
}
