using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._4
{
    internal class Program
    {
        static bool soCP(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so can kiem tra: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (soCP(n))
            {
                Console.WriteLine("So {0} la so chinh phuong.", n);
            }
            else
            {
                Console.WriteLine("So {0} khong phai la so chinh phuong.", n);
            }
            Console.ReadLine();
        }
    }
}
