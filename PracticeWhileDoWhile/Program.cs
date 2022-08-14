using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWhileDoWhile
{
    public class Program
    {
        static void Main(string[] args)
        {
            int average = 0;
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int i = n/2;

            while ( i < n)
            {
                average += i;
                i++;
            }

            average = average / (n/2);
            Console.Write("Trung binh cong tu n/2 den n la: " + average);
        }
    }
}
