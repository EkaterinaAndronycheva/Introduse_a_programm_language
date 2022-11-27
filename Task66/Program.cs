// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

namespace Task66
{
    class Program
    {
        static int Sum (int m, int n)
        {
            if (n == m) return n;
            else return m > n ? n + Sum(m, n+1) : m + Sum(n, m+1);         
        }
        static void Main()
        {
            Console.WriteLine("Введите натуральное число M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите натуральное число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма = {Sum(m, n)}");
        }
    }
}
