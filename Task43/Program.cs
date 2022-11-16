// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

namespace Task43
{
    class Program
    {
        static (double x, double y) Podoibledoibleersection (double b1, double k1, double b2, double k2)
        {
            double x = 0, y = 0;
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            return (x, y);
        }
        static void Main()
        {
            Console.WriteLine("Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
            Console.WriteLine("Введите");
            Console.Write("b1 = ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("k1 = ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b2 = ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("k2 = ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Podoibledoibleersection(b1, k1, b2, k2));
        }
    }
}
