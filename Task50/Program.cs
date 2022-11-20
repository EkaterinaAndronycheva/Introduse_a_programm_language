// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

using System;

namespace Task50
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

        static (bool isLife, int element) FindElementMatrix (int[,] matrix, int row, int column)
        {
            bool isLife;
            int element;
            if ((row+1) > matrix.GetLength(0) || (column+1) > matrix.GetLength(1) || row < 0 || column < 0)
            {
                isLife = false;
                element = 0;
            }
            else
            {
                isLife = true;
                element = matrix[row, column];
            }
            return (isLife, element);
        }

        static void Main(string[] args)
        {
            int[,] array2D = CreateMatrixRndInt(3, 4, 0, 100);
            Console.WriteLine("Программа на вход принимает позиции элемента в двумерном массиве");
            Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
            Console.WriteLine("Двумерный массив:");
            PrintMatrix(array2D);
            Console.WriteLine("Введите позицию элемента");
            Console.Write("Столбец: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Строка: ");
            int j = Convert.ToInt32(Console.ReadLine());

            i--; j--;
            var res = FindElementMatrix(array2D, j, i);
            if (res.isLife == false) Console.WriteLine("Такого элемента в массиве нет.");
            else Console.WriteLine($"Элемент [{++i}, {++j}] равен {res.element}");
        }
    }
}
