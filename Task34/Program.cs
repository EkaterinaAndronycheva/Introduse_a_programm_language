// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

namespace Task34
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

        static int SumEvenNumbers(int[] a)
        {
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 == 0) count++;
            }
            return count;
        }
        static void Main()
        {
            int[] array = CreateArrayRndInt(10, 100, 1000);
            PrintArray(array);
            int sumEvenNumbers = SumEvenNumbers(array);
            Console.WriteLine($"Количество четных элементов равно {sumEvenNumbers}");
        }
    }
}
