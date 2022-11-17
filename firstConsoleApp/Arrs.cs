using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace firstConsoleApp
{
    public class Arrs
    {
        

        public static int[] randArray(int length) 
        {
            Random rand = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++) 
            {
                array[i] = rand.Next(-100, 100);
            }
            return array;
        }
        public static void PrintArray(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        public static void ArrsCase1(int[] arr) 
        {
            PrintArray(arr);
            for (int i = 0; i <arr.Length; i++) 
            {
                if ((arr[i] < 0) & (arr[i] % 3 != 0)) 
                {
                    arr[i] = Math.Abs(arr[i]);
                }
            }
            PrintArray(arr);
        }

        public static int FindMinimal(int[] arr) 
        {
            int min = 0;
            foreach (int elem in arr) 
            {
                if (elem < min) { min = elem; }
            }
            return min;
        }

        public static void ArrsCase2(int[] arr) 
        {
            PrintArray(arr);
            int min = FindMinimal(arr);
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == min) { arr[i] = Math.Abs(arr[i]); }
            }
            PrintArray(arr);
        }
    }
}
