using System;


namespace consoleApp {
    class Program {
        public static void Main(string[] args) {
            //Case1(); //Сумма двух чисел
            //Case2(); //Обратное выражение
            //Case3(); //Сумма трёх чисел
            //Case4(); //Произведение double чисел
            //Case5(); //Деление a на b
            Case5(); //
        }
        public static void Case1() {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
        }
        public static void Case2() {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={b}+{a}");
        }
        public static void Case3() {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}+{c}={a + b + c}");
        }
        public static void Case4() {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double final = Math.Round((a * b), 1);
            Console.WriteLine($"{a}*{b}={final}");
        }
        public static void Case5() {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0) {
                double final = Math.Round((a / b), 3);
                Console.WriteLine($"{a}/{b}={final}");
            }
            else { Console.WriteLine("Нельзя поделить на ноль");}
        }
        public static void Case6() {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"({a}+{b})+{c}={a:#.##}+({b:#.##}+{c:#.##})");
        }
        public static void Case7()
        {
            Console.Write("Номинал купюры:");
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Количество купюр:");
            uint b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Сумма денег: ");
        }
    }
}