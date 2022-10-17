// Задача 6: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

using System;

namespace Task06
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа выводит результат о чётности числа.");
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 00) Console.WriteLine($"Число {num} четное");
            else Console.WriteLine ($"Число {num} не четное");
        }
    }
}
