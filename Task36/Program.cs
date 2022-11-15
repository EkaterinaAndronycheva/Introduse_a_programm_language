// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

namespace Task36
{
    class Program
    {
        static int[] CreateArrayRndInt(int size, int min, int max)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }

        static void PrintArray (int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if(i < array.Length - 1) Console.Write($"{array[i]},");
                else Console.Write($"{array[i]}");
            }
            Console.WriteLine("]");
        }

        static int SumUnevenPos(int[] a)
        {
            int sum = 0;
            for(int i = 1; i < a.Length; i += 2) sum += a[i];
            return sum;
        }

        static void Main()
        {
            int[] array = CreateArrayRndInt(4, 1, 9);
            PrintArray(array);
            int sumUnevenPos = SumUnevenPos(array);
            Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sumUnevenPos}");
        }
    }
}
