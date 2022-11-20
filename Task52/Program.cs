// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

namespace Task52
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

        static double[] ArithmeticalMeanColumns (int[,] matrix)
        {
            double[] res = new double[matrix.GetLength(1)];
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                res[i] = sum / matrix.GetLength(0);
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[,] array2D = CreateMatrixRndInt(3, 4, 0, 100);
            Console.WriteLine("Задан массив:");
            PrintMatrix(array2D);
            Console.Write("Среднее арифметическое каждого столбца: ");
            double[] result = ArithmeticalMeanColumns(array2D);
            for (int i = 0; i < result.Length; i++)
            {
                if (i == result.Length - 1) Console.Write($"{Math.Round(result[i], 2)}.");
                else Console.Write($"{Math.Round(result[i], 2)}; ");
            }
        }
    }
}
