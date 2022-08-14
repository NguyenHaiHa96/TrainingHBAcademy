using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            
            if (a > b)
            {
                for (int i = b; i < a; i++)
                {
                    sum += i;
                }
            }
            
            if (b > a)
            {
                for (int i = a; i < b; i++)
                {
                    sum += i;
                }
            }

            Console.Write("Tong tat ca cac so trong khoang tu a den b la: " + sum);
        }
    }
}

