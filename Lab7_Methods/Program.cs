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
            Console.WriteLine("Введите целое число больше нуля ");
            int a = Convert.ToInt32(Console.ReadLine());
            float S, V;
            CountCubeVolume_Square(a, out S, out V);
            Console.WriteLine(S);
            Console.WriteLine(V);
            Console.ReadKey();
        }
       
        static int CountCubeVolume_Square(float a, out float S, out float V)
        {

            V = a * a * a;
            S = 6 * a * a;
            return S,V;
        }
    }
}
