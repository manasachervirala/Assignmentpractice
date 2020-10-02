using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static int nCr(int n,int r)
        {
            return fact(n) / (fact(r) * fact(n - r));
        }
        static int fact(int n)
        {
            int res = 1;

            for (int i = 2; i <= n; i++)
                res = res * i;
            return res;
        }
        static void Main(string[] args)
        {
            int n, r;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nCr=" + nCr(n, r));
        }
     
    }
    
}
