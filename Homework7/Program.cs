using System;

namespace Homework7
{
    internal class Program
    {
        // 1. Написать метод Resize, который изменяет размер массива.
        //    (метод должен иметь увеличить или уменьшить количество элементов массива)
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        // 2. Написать метод для добавления элемента в начало массива, 
        //    в конец массива и по указанному индексу
        static void AddElement<T>(ref T[] array, T element, int index)
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = newArray.Length - 1; i > index; i--)
            {
                newArray[i] = newArray[i - 1];
            }
            newArray[index] = element;
            array = newArray;
        }

        // 3. Написать методы для удаления элемента из начала массива,
        //    из конца массива и по указанному индексу
        // Удаление элемента по указанному индексу
        static void RemoveElementByIndex<T>(ref T[] array, int index)
        {
            T[] newArray = new T[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }
        // Удаление элемента из начала массива
        static void RemoveElementFromStart<T>(ref T[] array) => RemoveElementByIndex(ref array, 0);
        // Удаление элемента из конца массива
        static void RemoveElementFromEnd<T>(ref T[] array) => RemoveElementByIndex(ref array, array.Length - 1);

        // Вывод массива на консоль
        static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array at start:");
            PrintArray(array);

            Resize(ref array, 10);
            Console.WriteLine("Result of Resize method executing:");
            PrintArray(array);

            AddElement(ref array, 6, 5);
            Console.WriteLine("Result of AddElement method executing:");
            PrintArray(array);

            RemoveElementFromStart(ref array);
            Console.WriteLine("Result of RemoveElementFromStart method executing:");
            PrintArray(array);

            RemoveElementFromEnd(ref array);
            Console.WriteLine("Result of RemoveElementFromEnd method executing:");
            PrintArray(array);

            RemoveElementByIndex(ref array, 3);
            Console.WriteLine("Result of RemoveElementByIndex method executing:");
            PrintArray(array);
        }
    }
}
