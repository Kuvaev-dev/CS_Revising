using System;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Заполнить массив с клавиатуры
            Console.WriteLine("Enter size of array: ");
            int.TryParse(Console.ReadLine(), out int size);
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            // 2. Вывести массив в обратном порядке
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            // 3. Вывести сумму чётных чисел в массиве
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) sum += array[i];
            }
            Console.WriteLine($"Sum of odd elements: {sum}");

            // 4. Вывести наименьший элемент массива
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
            }
            Console.WriteLine(min);
        }
    }
}
