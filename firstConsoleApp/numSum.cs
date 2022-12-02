using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public static void numsCase1(int a, int b)
        {
            int[] values = Enumerable.Range(a, b).ToArray();
            foreach (int num in values)
            {
                Console.WriteLine($"{sumDigits(num)} - {num}");
            }
        }
        public static void numsCase2(int a, int b, int C)
        {
            int[] values = Enumerable.Range(a, b).ToArray();
            foreach (int num in values)
            {
                if (sumDigits(num) == C)
                {
                    Console.WriteLine($"{sumDigits(num)} - {num}");
                }
            }
        }
        public static void numsCase3(int a, int b)
        {
            int[] values = Enumerable.Range(a, b).ToArray();
            foreach (int num in values)
            {
                if (sumDigits(num) % 2 != 0)
                {
                    Console.WriteLine($"{sumDigits(num)} - {num}");
                }
            }
        }
        public static int numsCase4(int a, int b, int A)
        {
            int[] values = Enumerable.Range(1, 15).ToArray();
            Dictionary<int, int> digits = new Dictionary<int, int>();
            foreach (int num in values)
            {
                digits.Add(num, sumDigits(num));
            }
            digits.Reverse();
            foreach (KeyValuePair<int, int> num in digits)
            {
                if (num.Value == A)
                {
                    return num.Key;
                }
            }
            return 0;
        }
        public static void numsCase5(int A, int B, int X) 
        {
            for (int i = A; i <= B; i++) 
            {
                string IntStr = i.ToString();
                int last = IntStr[IntStr.Length - 1] - '0';
                if (last == X) 
                {
                    Console.WriteLine(i);
                };
                    
            }
        }
    }
}
