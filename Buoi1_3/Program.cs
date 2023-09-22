using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_3
{
    class Program
    {
        public static int tongLe(int a)
        {
            int tong = 0;
            for (int i = 1; i <= (2 * a - 1); i += 2)
            {
                tong += i;
            }
            return tong;
        }
        static void Main(string[] args)
        {
            int a;            
            Console.Write("nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("tong= " + tongLe(a));
            Console.ReadKey();

        }
    }
}
