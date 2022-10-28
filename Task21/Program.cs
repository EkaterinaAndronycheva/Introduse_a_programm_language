// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

namespace Task21
{
    class Program
    {
        static double DistanceP (double xx1,double yy1, double zz1, double xx2, double yy2, double zz2)
        {
            double dx = xx1 - xx2;
            double dy = yy1 - yy2;
            double dz = zz1 - zz2;
            double res = Math.Sqrt(dx*dx + dy*dy + dz*dz);
            return res;
        }
        static void Main()
        {
            Console.WriteLine("Введите координаты первой точки");
            Console.Write("X1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Z1 = ");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки");
            Console.Write("X2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Z2 = ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double result = Math.Round(DistanceP(x1,y1,z1,x2,y2,z2), 2, MidpointRounding.ToZero);
            Console.WriteLine($"Расстояние между точками ({x1},{y1},{z1}) и ({x2},{y2},{z2}) равно {result}");
        }
    }
}
