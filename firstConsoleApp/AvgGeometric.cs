using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    class AvgGeo
    {
        public static void avgGeometric()
        {
            Console.Write("Введите первое число:");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите второе число:");
            int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            //Среднее геометрическое
            Console.WriteLine("Среднее геометрическое модулей числа a и b: {0:F}", Math.Sqrt(a * b));
        }
    }
}