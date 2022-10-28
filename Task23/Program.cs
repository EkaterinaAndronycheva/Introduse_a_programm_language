// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

using System;

namespace Task23
{
    class Program
    {
        static void PrintCubes(int x)
        {
            Console.WriteLine($"{x} ->");
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{i} | {Math.Pow(i,3)}");
            }
        }
        static void Main()
        {
            Console.Write("Введите число: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n < 1) Console.WriteLine("Введено отрицательное число или нуль!");
                else
                {
                    PrintCubes(n);
                }   
                
            }
            else Console.WriteLine("Введено некорректное значение!");
        }
    }
}
