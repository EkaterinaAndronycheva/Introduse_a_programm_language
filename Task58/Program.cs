// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

namespace Task58
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
        static (int[,] res, bool isCan) MultMatrix (int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                bool isCan = false;
                int[,] res = CreateMatrixRndInt(1, 1, 1, 1);
                return (res, isCan);
            }
            else
            {
                bool isCan = true;
                int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                for (int i = 0; i < res.GetLength(0); i++)
                {
                    for (int j = 0; j < res.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        {
                            res[i,j] += matrix1[i,k] * matrix2[k,j];
                        }
                    }
                }
                return (res, isCan);
            }           
        }
        static void Main()
        {
            int[,] array2D1 = CreateMatrixRndInt(2, 2, 0, 9);
            int[,] array2D2 = CreateMatrixRndInt(2, 1, 0, 9);
            Console.WriteLine("Заданы матрицы:");
            PrintMatrix(array2D1);
            Console.WriteLine();
            PrintMatrix(array2D2);
            
            var tuple = MultMatrix(array2D1, array2D2);
            if (tuple.Item2)
            {
                Console.WriteLine("Результат умножения");
                PrintMatrix(tuple.Item1);
            }
            else Console.WriteLine("Введенные матрицы нельзя умножить!");
        }
    }
}
