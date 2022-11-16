// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

using System;

namespace Task41
{
    class Program
    {
        static int HowManyPositiveNum (int[] a)
        {
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0) count++;
            }
            return count;
        }
        static void Main()
        {
            Console.WriteLine("Введите количество чисел");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {m} чисел");
            int[] array = new int[m];
            for(int i = 0; i < m; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Количество положительных чисел составляет {HowManyPositiveNum(array)}");
        }
    }
}
