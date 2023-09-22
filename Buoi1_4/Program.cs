using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_4
{
    class Program
    {
        public static void chuViDienTich(int a, int b, int c)
        {
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
            {
                double P = 0, S = 0;

                P = a + b + c;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.WriteLine("Chu vi= {0}, Dien tich= {1}", P, S);
            }
            else
            {
                Console.WriteLine("Khong phai 3 canh tam giac");

            }
        }
        static void Main(string[] args)
        {
            int a, b, c; 
          
            Console.Write("nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("nhap so c: ");
            c = Int32.Parse(Console.ReadLine());
            chuViDienTich(a, b, c);
            Console.ReadKey();

        }
    }
}
