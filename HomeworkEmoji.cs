using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace emodji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите emoji");
            string str = Console.ReadLine();
            string str1 = @"^[;:]{1}\-*([\(\)\[\]]+)$";
            bool result = Regex.Match(str, str1).Success;
            if (result)
            {
                Console.WriteLine("классный смайлик!");
            }
            else
            {
                Console.WriteLine("Ошибка, несуществующий смайлик");
            }
            Console.ReadKey();
        }
        
    } 
}
