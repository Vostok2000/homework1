using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyLoveHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {   double R = 5;
            Console.WriteLine("Введите координаты точки N (целые числа)");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(R, 2) >= (Math.Pow(x, 2) + Math.Pow(y, 2)) && (y >= x) && (y >= 0))
            {
                Console.WriteLine("Точка N принадлежит заштрихованной части плоскости ");
            }
            else
            {
                Console.WriteLine("Точка N не принадлежит заштрихованной части плоскости");
            } 
            Console.ReadKey();
        }
    }
}
