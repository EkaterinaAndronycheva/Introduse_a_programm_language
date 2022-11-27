// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;

namespace Task54
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
        static void SortDesRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[columns];
                for (int j = 0; j < columns; j++)
                    row[j] = matrix[i, j];
                BubbleSort(row);
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = row[j];
            }
        }
        static void BubbleSort(int[] array) //по убыванию
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] < array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
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

        static void Main()
        {
            int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);
            Console.WriteLine("Задан массив:");
            PrintMatrix(array2D);
            Console.WriteLine("Массив, в котором упорядочены элементы строк по убыванию:");
            SortDesRows(array2D);
            PrintMatrix(array2D);
        }
    }
}
