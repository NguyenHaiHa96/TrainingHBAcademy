using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIfElse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("So lon nhat la: " + a);
            }
            else if (a < b && a < c)
            {
                Console.WriteLine("So be nhat la: " + a);
            }

            if (b > a && b > c)
            {
                Console.WriteLine("So lon nhat la: " + b);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("So be nhat la: " + b);
            }

            if (c > a && c > b)
            {
                Console.WriteLine("So lon nhat la: " + c);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("So be nhat la: " + c);
            }
        }
    }
}
