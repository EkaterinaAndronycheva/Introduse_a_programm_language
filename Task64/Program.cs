// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

namespace Task64
{
    class Program
    {
        static void NaturalNumbers (int n)
        {
            if (n == 0) return;
            Console.Write($"{n} ");
            NaturalNumbers(n - 1);           
        }
        static void Main()
        {
            Console.WriteLine("Введите натуральное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            NaturalNumbers(num);
        }
    }
}
