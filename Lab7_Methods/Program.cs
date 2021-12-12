using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать метод для вычисления объема и площади поверхности куба по длине его ребра. 
namespace Lab7_Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double S, V;
            CountCubeVolume_Square(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба равна: {0}", S);
            Console.WriteLine("Обьем куба равен: {0}", V);
            Console.ReadKey();
        }

        static void CountCubeVolume_Square(double a, out double S, out double V)
        {

            V = a * a * a;
            S = 6 * a * a;

        }
    }
}
