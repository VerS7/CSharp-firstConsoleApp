using System;


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
    }
}
