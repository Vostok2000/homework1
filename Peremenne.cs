using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пе
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b=Convert.ToInt32(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("Первое число= " + a);
            Console.WriteLine("Второе число= " + b);
            Console.ReadKey();


        }
    }
}
