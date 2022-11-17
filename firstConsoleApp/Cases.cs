using System;


namespace firstConsoleApp
{
    public class Cases
    {
        public static void Case4()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a}*{b}={a * b:f1}");
        }
    }
}
