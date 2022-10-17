// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;

namespace Task13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа выводит третью цифру заданного числа.");
            Console.WriteLine("Введите число: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введено некорректое значение");
            }
            else
            {     
                if (n < 0) n *= -1;           
                if (n < 100) 
                {
                    Console.WriteLine("Третьей цифры нет");
                }
                else
                {
                    while (n > 999)
                    {
                        n /= 10;
                    }
                Console.WriteLine(n%10);
                }              
            }
            
        }
    }
}
