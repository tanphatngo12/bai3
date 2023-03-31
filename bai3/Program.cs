using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            if (x%3==0)
            {
                Console.WriteLine("x chia het cho 3");
            }
            else
            {
                Console.WriteLine("x khong chia het cho 3");
            }
            Console.ReadLine();
        }
    }
}
