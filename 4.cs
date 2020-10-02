using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("natural numbers in reverse order");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("i=" + i);
            }

            Console.ReadKey();
        }
    }
}
