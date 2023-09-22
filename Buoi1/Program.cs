using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, tong, hieu, tich;
            double thuong = 0;
            Console.Write("nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            b = Int32.Parse(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            if (b != 0)
            {
                thuong = (double)a / b;
            }
            Console.WriteLine("tong= " + tong);
            Console.WriteLine("hieu= {0}", hieu);
            Console.WriteLine("tich= {0}, thuong= {1}", tich, thuong);
            Console.ReadKey();

        }
    }
}
