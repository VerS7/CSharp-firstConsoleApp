using System;


namespace firstConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            //модуль числа
            if (a < 0)
                a = -a;
            if (b < 0)
                b = -b;
            //Среднее геометрическое
            Console.WriteLine("Среднее геометрическое модулей числа a и b: {0:F}", Math.Sqrt(a * b));
        }
    }
}