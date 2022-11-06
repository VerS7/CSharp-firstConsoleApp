using System;


namespace firstConsoleApp
{
    public class Cases
    {
        public static void Case1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
        }
        public static void Case2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={b}+{a}");
        }
        public static void Case3()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}+{c}={a + b + c}");
        }
        public static void Case4()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a}*{b}={a * b:f1}");
        }
        public static void Case5()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                ;
                Console.WriteLine($"{a}/{b}={a / b:f3}");
            }
            else { Console.WriteLine("Нельзя поделить на ноль"); }
        }
        public static void Case6()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"({0}+{1})+{2}={a:f2}+({b:f2}+{c:f2})");
        }
        public static void Case7()
        {
            Console.Write("Номинал купюры:");
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Количество купюр:");
            uint b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Сумма денег:{a * b:f2}р.");
        }
        public static void Case8()
        {
            Console.Write("Введите сумму вклада:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите процент по вкладу:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Через го начислят: {a / 100 * b:f2}р");
        }
        public static void Case9()
        {
            Console.Write("Введите сумму вклада:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите процент по вкладу:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Через сумма на вкладе равна: {a + (a / 100 * b):f2}р");
        }
        public static void Case10()
        {
            const int currYear = 2009;
            Console.Write("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.Write("Сколько тебе лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name}, ты родился в {currYear - age} году.");
        }
    }
}
