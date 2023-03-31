using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool kq = ktsngto(n);
            for (int i = 1; i < n; i ++ )
            {
                if (ktsngto(i)==true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
        public static bool ktsngto(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
