using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_6
{
    class Program
    {
        static void giaiPTBac2(double a, double b, double c)
        {
            
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.Write("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                }
                return;
            }
            
            double delta = b * b - 4 * a * c;
            double x1;
            double x2;
           
            if (delta > 0)
            {
                x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Nhap a: ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap b: ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap c: ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            giaiPTBac2(a, b, c);
            Console.ReadKey();

        }
    }
}
