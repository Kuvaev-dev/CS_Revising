using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triangles' height: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int height);

            if (!isParsed || height <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            Console.WriteLine();

            // 1. Увеличивающийся треугольник слева
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2. Убывающий треугольник слева
            for (int i = height; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 3. Увеличивающийся треугольник справа
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 4. Убывающий треугольник справа
            for (int i = height; i > 0; i--)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
