using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWhileDoWhile
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int sum = 0;
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            while (a < n)
            {
                if (a % 2 == 0 && a % 3 == 0)
                {
                    sum += a;
                }
                a++;
            }

            Console.WriteLine("Tong cac phan tu tu 0 den n chia het cho 2 va 3 la: " + sum);
        }
    }
}
