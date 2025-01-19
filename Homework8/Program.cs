using System;

namespace Homework8
{
    internal class Program
    {
        // 1. Реализовать вывод массива с помощью рекурсии
        public static void PrintArray(int[] array, int index = 0)
        {
            if (index < array.Length)
            {
                Console.Write($"{array[index]} ");
                PrintArray(array, index + 1);
            }
            Console.WriteLine();
        }

        // 2. Найти сумму элементов массива с помощью рекурсии
        public static int SumArray(int[] array, int index = 0)
        {
            if (index < array.Length)
            {
                return array[index] + SumArray(array, index + 1);
            }
            return 0;
        }

        // 3. Найти сумму цифр числа с помощью рекурсии
        public static int SumDigits(int number)
        {
            if (number < 10)
            {
                return number;
            }
            return number % 10 + SumDigits(number / 10);
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            PrintArray(array); 
            Console.WriteLine(SumArray(array));
            Console.WriteLine(SumDigits(12345));
        }
    }
}
