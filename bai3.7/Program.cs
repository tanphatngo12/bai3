using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace bai3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong: " + Tong(n,sum));
            Console.ReadLine();
        }
        public static int Tong(int n, int sum)
        {
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            return sum;
        }
        
    }
}
