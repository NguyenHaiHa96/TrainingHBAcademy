using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] numbers = new int[2];
            Console.Write("Nhap so thu nhat: ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            numbers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Thu tu 2 so vua nhap vao la: " + numbers[0] + " " + numbers[1]);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] % 2 == 0 && numbers[j] % 2 == 0)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Thu tu 2 so sau khi sap xep la: " + numbers[0] + " " + numbers[1]);
        }
    }
}
