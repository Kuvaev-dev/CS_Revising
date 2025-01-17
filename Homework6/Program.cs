using System;

namespace Homework6
{
    /*
        1. Напиать метод, который выводит на экран строку.
           Символы из которых состоит строка и их количетсво вводятся пользователем.
       
        2. Напиать метод для поиска индекса элемента массива (тип элементов в массиве - int),
           метод должен вернуть индекс первого найденого єлемента (если он будет найден)
    */
    internal class Program
    {
        // Задание 1
        static void PrintStringOfSymbols(char symbol, uint countOfSymbols)
        {
            for (int i = 0; i < countOfSymbols; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        // Задание 2
        static int FindIndexOfElement(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Enter count of symbols:");
            uint.TryParse(Console.ReadLine(), out uint countOfSymbols);

            Console.WriteLine("Enter symbol:");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nYour string:");
            PrintStringOfSymbols(symbol, countOfSymbols);

            Console.WriteLine();

            // Задание 2
            Console.WriteLine("Enter count of elements: ");
            int.TryParse(Console.ReadLine(), out int countOfElements);

            int[] array = new int[countOfElements];
            for (int i = 0; i < countOfElements; i++)
            {
                Console.WriteLine($"array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter an element to find: ");
            int.TryParse(Console.ReadLine(), out int element);

            int index = FindIndexOfElement(array, element);
            Console.WriteLine($"Index of element {element}: {index}");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
