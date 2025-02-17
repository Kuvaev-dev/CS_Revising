﻿using System;
using System.Text;

namespace Homework1
{
    internal class Program
    {
        // Задание 1. Найти среднее арифметическое двух чисел
        public static double FirstTask(double firstValue, double secondValue) => (firstValue + secondValue) / 2;

        // Задание 2. Найти сумму и произведение трёх чисел
        public static void SecondTask(double firstValue, double secondValue, double thirdValue) =>
            Console.WriteLine($"\nСумма чисел: {firstValue + secondValue + thirdValue}\nПроизведение чисел: {firstValue * secondValue * thirdValue}");

        // Задание 3. Мини-конвертер валют (USD/EUR -> UAH)
        public static void ThirdTask(double money, int currency)
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
                Console.WriteLine($"РЕЗУЛЬТАТ: {FirstTask(firstTaskFirstValue, firstTaskSecondValue)}");

                Console.Write("\n\n\nЗадание 2. Найти сумму и произведение трёх чисел\nВведите первое число: ");
                double.TryParse(Console.ReadLine(), out double secondTaskFirstValue);
                Console.Write("Введите второе число: ");
                double.TryParse(Console.ReadLine(), out double secondTaskSecondValue);
                Console.Write("Введите второе число: ");
                double.TryParse(Console.ReadLine(), out double secondTaskThirdValue);
                Console.Write("РЕЗУЛЬТАТ: ");
                SecondTask(secondTaskFirstValue, secondTaskSecondValue, secondTaskThirdValue);

                Console.Write("\n\n\nЗадание 3. Мини-конвертер валют (USD/EUR -> UAH)\nВыберите валюту:\n1. USD\n2. EUR\nВаш выбор: ");
                int.TryParse(Console.ReadLine(), out int currencyChoice);
                Console.Write("Введите количество денег: ");
                double.TryParse(Console.ReadLine(), out double sumOfMoney);
                Console.Write("РЕЗУЛЬТАТ:\n");
                ThirdTask(sumOfMoney, currencyChoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
