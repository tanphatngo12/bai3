using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang: ");
            string thang = Console.ReadLine();
            int th = int.Parse(thang);
            int songay = 0;
            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 2: songay = 28; break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;
                }
            }
            Console.WriteLine("Thang {0} co {1} ngay",th,songay);
            Console.ReadLine();
        }
    }
}
