// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.


using System;

namespace Task29
{
    class Program
    {
        static int[] RandArrayEight()
        {
            int[] a = new int[8];
            for(int i = 0; i < 8; i++)
            {
                a[i] = new Random().Next(0, 100);
            }
            return a;
        }
        static void PrintArray(int[] x)
        {
            Console.Write("[");
            for(int i = 0; i < x.Length - 1; i++)
            {
                Console.Write($"{x[i]}, ");
            }
            int t = x[x.Length-1];
            Console.Write($"{t}]");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит массив из 8ми случайных чисел от 0 до 100.");
            int[] array = RandArrayEight();
            PrintArray(array);
        }
    }
}
