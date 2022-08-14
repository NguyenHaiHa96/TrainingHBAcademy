using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            Console.Write("Nhap so n: ");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 0:
                    Console.WriteLine("Khum co ngay nay trong tuan.");
                    break;
                case 1:
                    Console.WriteLine("Khum co ngay nay trong tuan.");
                    break;
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                case 8:
                    Console.WriteLine("Chu nhat");
                    break;
                default:
                    Console.WriteLine("Khum co ngay nay trong tuan.");
                    break;
            }
        }
    }
}
