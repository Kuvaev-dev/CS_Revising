using System;
using System.Text;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание: Проверить число на чётность с использованием if-else

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.OutputEncoding = Encoding.Unicode;

                Console.WriteLine("Введите ваше число: ");
                double.TryParse(Console.ReadLine(), out double value);

                if (value % 2 == 0) Console.WriteLine("Число чётное");
                else Console.WriteLine("Число нечётное");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
