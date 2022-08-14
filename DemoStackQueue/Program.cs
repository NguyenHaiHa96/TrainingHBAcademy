using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            Console.Write("Nhap chuoi ki tu: ");
            string s = Console.ReadLine();
            int n = s.Length;
            char[] chars = new char[n];
            for (int i = 0; i < n; i++)
            {
                chars[i] = s[i]; 
                stack.Push(chars[i]);
            }

            Console.Write("Chuoi dao nguoc la: ");
            for (int i = 0; i < n; i++)
            {
                chars[i] = stack.Pop();
                Console.Write(chars[i]);
            }
        }
    }
}
