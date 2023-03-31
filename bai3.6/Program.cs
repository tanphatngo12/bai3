using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int s=0;
            Console.WriteLine("Nhap so nguyen n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong S la " + Tinh(n, s));
            Console.ReadLine();
        }
        public static int Tinh(int n, int s)
        {
            for (int i=1; i<=n; i++)
            {
                s += i * i;
            }
            return s;
        }
    }
}
