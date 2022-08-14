using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            string[] nameComponent = name.Split(" ");

            for (int i = 0; i < nameComponent.Length; i++)
            {
                char[] chars = nameComponent[i].ToCharArray();

                Stack<char> stack = new Stack<char>();
                for (int j = 0; j < chars.Length; j++)
                {
                    stack.Push(chars[j]);
                }          

                for (int j = 0; j < nameComponent[i].Length; ++j)
                {
                    chars[j] = stack.Pop();
                }
                nameComponent[i] = new string(chars);

                queue.Enqueue(nameComponent[i]);
            }

            Console.Write("Chuoi ki tu nguoc lai voi moi ten la: ");
            for (int i = 0; i < nameComponent.Length; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
