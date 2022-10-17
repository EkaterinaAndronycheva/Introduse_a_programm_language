// Задача 8: Напишите программу, которая на вход принимает число (N), 
///а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

namespace Task08
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа выводит все четные числа от 1 до N.");
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Введено некорректное число.");
            }
            else
            {
                for (int i = 2; i <= n; i+=2)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
