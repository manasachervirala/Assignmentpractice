using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            Console.WriteLine("top most element is {0}", s.Peek());
            foreach(int x in s)
            {
                Console.WriteLine(x);
            }
            s.Pop();
            Console.WriteLine("The Topmost elemen after poping twice is {0}", s.Peek());
            foreach(int x in s)
            {
                Console.WriteLine(x);
            }
            s.Push(40);
            foreach (int x in s)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

        }
    }
}
