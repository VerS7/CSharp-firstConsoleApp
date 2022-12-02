using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstConsoleApp
{
    public class Formula
    {
        public static double func(double a)
        {
            double final = Math.Sqrt(5 - Math.Pow(a, 3));
            if (final > 0)
            {
                return final;
            }
            else
            {
                Console.WriteLine("Функция не определена.");
                return 0;
            }

        }

        public static double func1(double a)
        {
            double final = Math.Pow(a, 3) - Math.Sin(a);
            return final; 
        }
        
        public static int func1Case(int a, int b) 
        {
            return func1(a) > func1(b) ? a : b;
        }

        public static double func2(double x)
        {
            if (Math.Abs(x) <= 0.1)
            {
                return Math.Pow(x, 3) - 0.1;
            }
            else if (Math.Abs(x) > 0.1 && Math.Abs(x) < 0.2)
            {
                return 0.2 * x - 0.1;
            }
            else if (Math.Abs(x) > 0.2)
            {
                return Math.Pow(x, 3) + 0.1;
            }
            else return 0;
        }

        public static Dictionary<int, string> mCards = new Dictionary<int, string>()
        {
            { 1, "Пики" },
            { 2, "Трефы" },
            { 3, "Бубны" },
            { 4, "Черви" }
        };
        public static Dictionary<int, string> kCards = new Dictionary<int, string>()
        {
            { 6, "Шестёрка" },
            { 10, "Десятка" },
            { 11, "Валет" },
            { 12, "Дама" },
            { 13, "Король" },
            { 14, "Туз" }
        };
        public static void cards(int m, int k)
        {
            if (mCards.ContainsKey(m) & kCards.ContainsKey(k)) 
            { 
                Console.WriteLine($"{kCards[k]} {mCards[m]}"); 
            }  
            else { Console.WriteLine("Нет такой карты."); };
        }
        public static void funcCase(double a, double b, double h) 
        { 
            for (double i = a; i < b; i+=h) 
            {
                Console.WriteLine($"{Math.Round(i, 5)} | {Math.Round(func2(i), 5)}");
            } 
        }
    }
}
