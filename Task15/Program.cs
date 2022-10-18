// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using System;

namespace Task15
{
    class Program
    {
        static void PrintIsHoliday (int day)
        {
            if (day == 1) Console.WriteLine("Это не выходной день");
            else if (day == 2) Console.WriteLine("Это не выходной день");
            else if (day == 3) Console.WriteLine("Это не выходной день");
            else if (day == 4) Console.WriteLine("Это не выходной день");
            else if (day == 5) Console.WriteLine("Это не выходной день");
            else if (day == 6) Console.WriteLine("Это выходной день");
            else if (day == 7) Console.WriteLine("Это выходной день");
        }
        static void Main()
        {
            Console.WriteLine("Введите цифру, обозначающую день недели: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n > 7 || n < 1) Console.WriteLine("Введено некорректное значение");
                else
                {
                    PrintIsHoliday(n);
                }
            }
            else Console.WriteLine("Введено некорректное значение");
        }
    }
}
