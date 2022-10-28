// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;

namespace Task19
{
    class Program
    {
        static bool PalindromFive(int x)
        {
            if (x%10 == x/10000)
            {
                int m = (x / 1000) % 10;
                int l = x / 10 % 10;
                if (m == l) return true;
            }
            return false;
        }
        static void Main()
        {
            Console.Write("Введите пятизначное число: ");
            int n;
            bool res = false;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n > 99999 || n < 10000) Console.WriteLine("Введено не пятизначное число!");
                else
                {
                    res = PalindromFive(n);
                    if (res == false) Console.WriteLine("Введенное число не является палиндромом.");
                    else Console.WriteLine("Введенное число - палиндром.");
                }   
                
            }
            else Console.WriteLine("Введено некорректное значение!");
            
        }
    }
}
