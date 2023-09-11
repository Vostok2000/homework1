using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newInt = 10;
            float newFloat = 8.4f;
            string newStr = "true";
            double bigInt = newInt * 3.5f;
            newFloat = newFloat - 1;
            string nnStr = newStr + "NoNoYesYesYes";
            Console.WriteLine("newInt = " + newInt);
            Console.WriteLine("newFloat = " + newFloat);
            Console.WriteLine("BigInt = " + bigInt);
            Console.WriteLine("NewStr = " + newStr);
            Console.WriteLine("newNewStr = " + nnStr);
            Console.WriteLine("newInt / newFloat = " + newInt / newFloat);
            Console.WriteLine("bigInt / newFloat = " + bigInt / newFloat);
            Console.ReadKey();
        }
    }
}
