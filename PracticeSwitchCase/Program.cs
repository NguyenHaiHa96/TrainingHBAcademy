using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int month = 0;
            Console.Write("Nhap so n: ");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 0:
                    Console.WriteLine("Khum co thang nay trong nam.");
                    break;
                case 1:
                    Console.WriteLine("Thang mot.");
                    break;
                case 2:
                    Console.WriteLine("Thang hai");
                    break;
                case 3:
                    Console.WriteLine("Thang ba");
                    break;
                case 4:
                    Console.WriteLine("Thang tu");
                    break;
                case 5:
                    Console.WriteLine("Thang nam");
                    break;
                case 6:
                    Console.WriteLine("Thang sau");
                    break;
                case 7:
                    Console.WriteLine("Thang bay");
                    break;
                case 8:
                    Console.WriteLine("Thang tam");
                    break;
                case 9:
                    Console.WriteLine("Thang chin");
                    break;
                case 10:
                    Console.WriteLine("Thang muoi");
                    break;
                case 11:
                    Console.WriteLine("Thang muoi mot");
                    break;
                case 12:
                    Console.WriteLine("Thang muoi hai");
                    break;
                default:
                    Console.WriteLine("Khum co thang nay trong nam.");
                    break;
            }
        }
    }
}
