// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

using System;
using System.Linq;

namespace Task60
{    
    class Program
    {
        static int[,,] CreateArray3DRndInt(int rows, int columns, int depth, int min, int max)
        {
            int[,,] matrix = new int[rows, columns, depth];
            int[] m = new int[rows*columns*depth];
            Random rnd = new Random();
            m[0] = rnd.Next(min, max + 1);

            for (int i = 0; i < m.Length; i++)
            {
                int t = rnd.Next(min, max + 1);
                while(m.Contains(t)) t = rnd.Next(min, max + 1);
                m[i] = t;
            }

            int l = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = m[l++];
            }                   
            return matrix;
        }

        static void PrintArray3D(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write($"{matrix[i,j,k], 4}" +$"({i},{j},{k})");
                    }
                }
            }   
        }
        static void Main()
        {
            int[,,] array3D = CreateArray3DRndInt(2, 2, 2, 10, 99);
            Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел:");
            PrintArray3D(array3D);
        }
    }
}