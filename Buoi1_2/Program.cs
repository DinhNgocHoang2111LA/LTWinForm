using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2
{
    class Program
    {
        public static bool checkNamNhuan(int nam)
        {
            if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
            {
                return true; 

            }
            else
            {
                return false; 
            }
        }
        static void Main(string[] args)
        {
            int thang, nam, ngay=0;
            Console.Write("nhap thang: ");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap nam: ");
            nam = Int32.Parse(Console.ReadLine());
            if (checkNamNhuan(nam) == true)
            {
                switch (thang)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12: ngay = 31; break;
                    case 4: case 6: case 9: case 11: ngay = 30; break;
                    case 2: ngay = 29; break;

                }
                Console.WriteLine("thang {0} nam {1} co: {2} ngay.", thang, nam, ngay);
            }
            else
            {
                switch (thang)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12: ngay = 31; break;
                    case 4: case 6: case 9: case 11: ngay = 30; break;
                    case 2: ngay = 28; break;

                }
                Console.WriteLine("thang {0} nam {1} co: {2} ngay.", thang, nam, ngay);

            }
            Console.ReadKey();

        }
    }
}
