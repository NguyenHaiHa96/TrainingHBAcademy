using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine()); ;
            }

            Console.Write("Cac phan tu chia het cho 2 va 3 la: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] % 3 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
