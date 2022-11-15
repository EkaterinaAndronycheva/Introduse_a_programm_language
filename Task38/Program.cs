// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

using System;

namespace Task38
{
    class Program
    {
        static double[] CreateArrayRndDouble(int size, int min, int max)
        {
            double[] array = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                double n = rnd.NextDouble() * (max - min) + min;
                array[i] = Math.Round(n, 1);
            }
            return array;
        }

        static void PrintArray (double[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if(i < array.Length - 1) Console.Write($"{array[i]}; ");
                else Console.Write($"{array[i]}");
            }
            Console.WriteLine("]");
        }
        static (double max, double min) ArrayMaxMin (double[] a)
        {
            var res = (max: a[1], min: a[1]);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > res.max) res.max = a[i];
                else if (a[i] < res.min) res.min = a[i];
            }
            return res;
        }
        static void Main()
        {
            double[] array = CreateArrayRndDouble(5, 1, 9);
            PrintArray(array);
            var diff = ArrayMaxMin(array);
            double difference = diff.max - diff.min;
            Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(difference, 1)}");
        }
    }
}
