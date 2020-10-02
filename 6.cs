using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1, n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                fact = fact * n;
                n--;
            }
            Console.WriteLine("fact=" + fact);
            Console.ReadKey();
        }
    }
}
