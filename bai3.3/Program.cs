using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong: " + Tong(n, sum));
            Console.ReadLine();
        }
        public static int Tong(int n,int sum)
        {
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
