using System;


namespace firstConsoleApp
{
    class Program1
    {
        /*public static void Main(string[] args)
        {
            int Per = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Площадь треугольника равна {squareTriagle(Per):f2}");
        }*/
        public static double squareTriagle(int p)
        /*Площадь равностор. треугольника через периметр*/
        {
            return Math.Pow(p / 3, 2) * Math.Sqrt(3) / 4; 
        }
    }
}