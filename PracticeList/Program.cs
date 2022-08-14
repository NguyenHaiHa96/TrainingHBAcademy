using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeList
{
    public class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                int a = int.Parse(Console.ReadLine());
                list.Add(a);
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            Console.Write("Danh sach day so tang dan la: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
     
        }
    }
}
