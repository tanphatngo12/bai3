using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Day Fibonacci voi 10 phan tu la : \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static int fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
