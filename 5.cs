using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0, r;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());

        while(n!=0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            Console.WriteLine("rev num is" + rev);
            Console.ReadKey();
               
                }
    }
}
