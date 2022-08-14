using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIfElse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so can kiem tra: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " la so chan");
            }
            else
            {
                Console.WriteLine(a + " la so le");
            }
        }
    }
}
