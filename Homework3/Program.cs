using System;

namespace Homework3
{
    internal class Program
    {
        // Задание: Подсчитать сумму и количество чётных и нечётных чисел в диапазоне,
        // указанном пользователем с использованием while
        static void Main(string[] args)
        {
            Console.Write("Enter min value: ");
            int.TryParse(Console.ReadLine(), out int minValue);
            Console.Write("Enter max value: ");
            int.TryParse(Console.ReadLine(), out int maxValue);

            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
            }

            int evenSum = 0, oddSum = 0;
            uint evenCount = 0, oddCount = 0;

            while (minValue <= maxValue)
            {
                if (minValue % 2 == 0)
                {
                    evenCount++;
                    evenSum += minValue;
                }
                else
                {
                    oddCount++;
                    oddSum += minValue;
                }
                minValue++;
            }

            Console.WriteLine($"Even numbers count = {evenCount}, Even numbers sum = {evenSum}");
            Console.WriteLine($"Odd numbers count = {oddCount}, Odd numbers sum = {oddSum}");
        }
    }
}
