using System;

namespace Task00
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int square = number * number;
            Console.WriteLine($"Квадрат числа {number} = {square}");
        }
    }
}
