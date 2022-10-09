using System;
using System.Collections.Generic;


namespace firstConsoleApp
{
    public class numSum
    {
        public static int sumDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public static void numsCase1()
        {
            int[] values = Enumerable.Range(10, 23).ToArray();
            foreach (int num in values)
            {
                Console.WriteLine($"{sumDigits(num)} - {num}");
            }
        }
        public static void numsCase2()
        {
            int C = 5;
            int[] values = Enumerable.Range(100, 15).ToArray();
            foreach (int num in values)
            {
                if (sumDigits(num) == C)
                {
                    Console.WriteLine($"{sumDigits(num)} - {num}");
                }
            }
        }
        public static void numsCase3()
        {
            int[] values = Enumerable.Range(100, 15).ToArray();
            foreach (int num in values)
            {
                if (sumDigits(num) % 2 != 0)
                {
                    Console.WriteLine($"{sumDigits(num)} - {num}");
                }
            }
        }
        /* public static void numsCase4()
        {
            int[] values = Enumerable.Range(100, 15).ToArray();
            foreach (int num in values)
            {
                if (sumDigits(num) % 2 != 0)
                {
                    Console.WriteLine($"{sumDigits(num)} - {num}");
                }
            }
        } */
    }
}
