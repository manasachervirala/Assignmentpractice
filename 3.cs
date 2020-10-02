using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, sum = 0, r;
            Console.WriteLine("enter a num");
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            while(n!=0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if(sum == a)
            {
                Console.WriteLine("amstrong");
            }
            else
            {
                Console.WriteLine("not a amstrong");
            }
            Console.ReadLine();
        }
    }
}
