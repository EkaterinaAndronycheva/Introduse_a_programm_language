// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

namespace Task27
{
    class Program
    {
        static int SumDigits (int x)
        {
            x = Math.Abs(x);
            int sum = default;
            while (x > 0)
            {
                sum += x%10;
                x /= 10;
            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine("Программа выводит сумму цифр числа.");
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} -> {SumDigits(a)}");
        }
    }
}
