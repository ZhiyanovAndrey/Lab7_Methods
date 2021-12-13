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
            Console.WriteLine("Введите длины сторон треугольника 1");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины сторон треугольника 2");
            double a = Convert.ToDouble(Console.ReadLine());
            int x1 = -1, y1 = 1;
            int x2 = 11, y2 = 5;
            int x3 = 0, y3 = 20;
            double firstSide = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double secondSide = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double thirdSide = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double p = (firstSide + secondSide + thirdSide) / 2;
            double Square = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            double Perimeter = firstSide + secondSide + thirdSide;



            Console.WriteLine("Периметр прямоугольника равен: " + Perimeter);
            Console.WriteLine("Плошадь прямоугольника равна: " + Square);
            Console.WriteLine("Стороны {0}\t{1}\t{2}", +firstSide, +secondSide, +thirdSide);
            Console.ReadKey();
        }

    }
}
