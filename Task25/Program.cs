// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

namespace Task25
{
    class Program
    {
        static double PowN (double x, double y)
        {
            double res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }
        static void Main()
        {
            Console.WriteLine("Программа возводит число А в натуральную степень B");
            Console.Write("Введите число А: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{a}, {b} -> {PowN(a, b)}");
        }
    }
}
