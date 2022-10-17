// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

namespace Task10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа выводит вторую цифру трехзначного числа");
            Console.WriteLine("Введите трехзначное число");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;

            if (n > 99 && n < 1000)
            {
                res = n / 10;
                res = res % 10;
                Console.WriteLine(res);
            }
            else Console.WriteLine("Введено некорректное число");
        }
    }
}
