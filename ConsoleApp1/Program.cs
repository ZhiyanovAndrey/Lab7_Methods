using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
 * (создать метод для вычисления  площади  треугольника по длинам его сторон). 
 * Для решения задачи можно использовать формулу Герона*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон треугольника №1 ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double Square1 = TriangleSquare(a, b, c);

            Console.WriteLine("Введите длины сторон треугольника №2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double Square2 = TriangleSquare(a2, b2, c2);


            Console.WriteLine("Площадь треугольника №1 равна: {0:0.00}", Square1);
            Console.WriteLine("Площадь треугольника №2 равна: {0:N2}", Square2);
            if (Square1 > Square2) Console.WriteLine("Площадь треугольника №1 больше");
            if (Square2 > Square1) Console.WriteLine("Площадь треугольника №2 больше");
            Console.ReadKey();
        }
        static double TriangleSquare(double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            double Square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Square;
        }

    }
}
