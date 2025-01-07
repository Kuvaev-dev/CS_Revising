using System;
using System.Text;

namespace Homework1
{
    internal class Program
    {
        // Задание 1. Найти среднее арифметическое двух чисел
        public static double Task1(double firstValue, double secondValue) => (firstValue + secondValue) / 2;

        // Задание 2. Найти сумму и произведение двух чисел
        public static void Task2(double firstValue, double secondValue) =>
            Console.WriteLine($"\nСумма чисел: {firstValue + secondValue}\nПроизведение чисел: {firstValue * secondValue}");

        // Задание 3. Мини-конвертер валют (USD/EUR -> UAH)
        public static void Task3(double money, int currency)
        {
            double USD_course = 42;
            double EUR_course = 44;
            switch (currency)
            {
                case 1: Console.WriteLine($"{money} USD = {money * USD_course} UAH"); break;
                case 2: Console.WriteLine($"{money} EUR = {money * EUR_course} UAH"); break;
                default: Console.WriteLine($"{money} USD = {money * USD_course} UAH"); break;
            }
        }

        static void Main()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Задание 1. Найти среднее арифметическое двух чисел\nВведите первое число: ");
                double.TryParse(Console.ReadLine(), out double firstTaskFirstValue);
                Console.Write("Введите второе число: ");
                double.TryParse(Console.ReadLine(), out double firstTaskSecondValue);
                Console.WriteLine($"РЕЗУЛЬТАТ: {Task1(firstTaskFirstValue, firstTaskSecondValue)}");

                Console.Write("\n\n\nЗадание 2. Найти сумму и произведение двух чисел\nВведите первое число: ");
                double.TryParse(Console.ReadLine(), out double seconfTaskFirstValue);
                Console.Write("Введите второе число: ");
                double.TryParse(Console.ReadLine(), out double seconfTaskSecondValue);
                Console.Write("РЕЗУЛЬТАТ: ");
                Task2(seconfTaskFirstValue, seconfTaskSecondValue);

                Console.Write("\n\n\nЗадание 3. Мини-конвертер валют (USD/EUR -> UAH)\nВыберите валюту:\n1. USD\n2. EUR\nВаш выбор: ");
                int.TryParse(Console.ReadLine(), out int currencyChoice);
                Console.Write("Введите количество денег: ");
                double.TryParse(Console.ReadLine(), out double sumOfMoney);
                Console.Write("РЕЗУЛЬТАТ:\n");
                Task3(sumOfMoney, currencyChoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
