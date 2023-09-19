using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer3
{
    internal class Program
    {
        static void Main(string[] args)
        {double x1n1=Convert.ToDouble(Console.ReadLine());//а)
         double x2n1 = Convert.ToDouble(Console.ReadLine());//а)
            double x1n2 = Convert.ToDouble(Console.ReadLine());//б)
            double x2n2 = Convert.ToDouble(Console.ReadLine());//б)
            double x3n2 = Convert.ToDouble(Console.ReadLine());//б)
            double t = Convert.ToDouble(Console.ReadLine());//в)
            double vn1 = Convert.ToDouble(Console.ReadLine());//в);
            double an_3 = Convert.ToDouble(Console.ReadLine());//в)
            double vn2 = Convert.ToDouble(Console.ReadLine());//г)
            double mn1 = Convert.ToDouble(Console.ReadLine());//г)
            double gn1 = Convert.ToDouble(Console.ReadLine());//г)
            double h = Convert.ToDouble(Console.ReadLine());//г)
            double R1 = Convert.ToDouble(Console.ReadLine());//д)
            double R2 = Convert.ToDouble(Console.ReadLine());//д)
            double mn2 = Convert.ToDouble(Console.ReadLine());//е)
            double gn2 = Convert.ToDouble(Console.ReadLine());//е)
            double alf = Convert.ToDouble(Console.ReadLine());//е)
            double R = Convert.ToDouble(Console.ReadLine());//ж)
            double bn1 = Convert.ToDouble(Console.ReadLine());//з)
            double an1 = Convert.ToDouble(Console.ReadLine());//з)
            double cn1 = Convert.ToDouble(Console.ReadLine());//з)
            double y = Convert.ToDouble(Console.ReadLine());//и)
            double m1n1 = Convert.ToDouble(Console.ReadLine());//и)
            double m2n1 = Convert.ToDouble(Console.ReadLine());//и)
            double r = Convert.ToDouble(Console.ReadLine());//и)
            double I = Convert.ToDouble(Console.ReadLine());//к)
            double Rn1 = Convert.ToDouble(Console.ReadLine());//к)
            double an2 = Convert.ToDouble(Console.ReadLine());//л)
            double bn2 = Convert.ToDouble(Console.ReadLine());//л)
            double cn2 = Convert.ToDouble(Console.ReadLine());//л)
            double an3 = Convert.ToDouble(Console.ReadLine());//м)
            double bn3= Convert.ToDouble(Console.ReadLine());//м)
            double cn3= Convert.ToDouble(Console.ReadLine());//м)
            double an4= Convert.ToDouble(Console.ReadLine());//н)
            double bn4= Convert.ToDouble(Console.ReadLine());//н)
            double cn4= Convert.ToDouble(Console.ReadLine());//н)
            double dn4= Convert.ToDouble(Console.ReadLine());//н)
            double xn1= Convert.ToDouble(Console.ReadLine());//о)
            double an5= Convert.ToDouble(Console.ReadLine());//п)
            double bn5= Convert.ToDouble(Console.ReadLine());//п)
            double cn5= Convert.ToDouble(Console.ReadLine());//п)
            double xn5= Convert.ToDouble(Console.ReadLine());//п)
            double xn6= Convert.ToDouble(Console.ReadLine());//р)
            double xn7= Convert.ToDouble(Console.ReadLine());//с)
            double xn8 = Convert.ToDouble(Console.ReadLine());//т)
            Console.WriteLine("а) " + Math.Sqrt(Math.Pow(x1n1, 2) + Math.Pow(x2n1, 2)));
            Console.WriteLine("б) " + (x1n2 * x2n2 + x1n1 * x3n2 + x2n2 * x3n2));
            Console.WriteLine("в) " + (vn1 * t + (an_3 * Math.Pow(vn1, 2)) / 2));
            Console.WriteLine("г) " + ((mn1 * Math.Pow(vn2, 2) / 2 + mn1 * gn1 * h)));
            Console.WriteLine("д) " + (1/R1+1/R2));
            Console.WriteLine("е) " + (mn2 * gn2 * Math.Cos(alf)));
            Console.WriteLine("ж) " + (2 * Math.PI * R));
            Console.WriteLine("з) " + (Math.Pow(bn1, 2) - 4 * an1 * cn1));
            Console.WriteLine("и) " + (y * (m1n1 * m2n1) / Math.Pow(r, 2)));
            Console.WriteLine("к) " + (Math.Pow(I, 2) * Rn1));
            Console.WriteLine("л) " + (an2 * bn2 * Math.Sin(cn2)));
            Console.WriteLine("м) " + (Math.Sqrt(Math.Pow(an3, 2) + Math.Pow(bn3, 2) - 2 * an3 * bn3 * Math.Cos(cn3))));
            Console.WriteLine("н) " + ((an4 * dn4 + bn4 * cn4) / an4 * dn4));
            Console.WriteLine("о) " + (Math.Sqrt(1 - Math.Pow(Math.Sin(xn1), 2))));
            Console.WriteLine("п) " + (1 / (Math.Sqrt(an5 * Math.Pow(xn5, 2) + bn5 * xn5 + cn5))));
            Console.WriteLine("р) " + (Math.Sqrt(xn6+1) + Math.Sqrt(xn6-1))/(2* Math.Sqrt(xn6)));
            Console.WriteLine("с) " + (Math.Abs(xn7) + Math.Abs(xn7 + 1)));
            Console.WriteLine("т) " + (Math.Abs(1 - Math.Abs(xn8))));
            Console.ReadLine();



        }
    }
}
