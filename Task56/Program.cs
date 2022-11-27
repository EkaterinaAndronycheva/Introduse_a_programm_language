// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

namespace Task56
{
    class Program
    {
        static int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
        {
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, j] = rnd.Next(min, max + 1);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5}");
                    else Console.Write($"{matrix[i,j], 5}");
                }
                Console.WriteLine("|");
            }
        }
        static int RowMinSum (int[,] matrix)
        {
            int[] minSum = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++) 
                for (int j = 0; j < matrix.GetLength(1); j++)
                    minSum[i] += matrix[i,j];

            int res = minSum[0];
            int ires = 0;
            for (int i = 1; i < minSum.Length; i++)
                if (minSum[i] < res)
                {
                    ires = i;
                    res = minSum[i];
                }
            return ires;
        }
        static void Main()
        {
             int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);
            Console.WriteLine("Задан массив:");
            PrintMatrix(array2D);
            Console.Write($"Номер строки с наименьшей суммой элементов(отсчет от нуля): {RowMinSum(array2D)}");
            
        }
    }
}
