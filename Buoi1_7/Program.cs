using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_7
{
    class Program
    {
        public static bool checkNgto(int a)
        {
            if(a==2){
                return true;
            }
            else{

                for (int i = 2; i < a; i++ )
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;

            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Danh sach so nguyen to tu 1 den n: ");

            for (int i = 2; i <= n; i++)
            {
                if (checkNgto(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}
