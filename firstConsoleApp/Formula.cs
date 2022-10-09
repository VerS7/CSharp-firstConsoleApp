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
    }
}
