using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.Write("{0}*{1}={2}", n, i, n * i);
            }
            Console.ReadKey();
                
        }
    }
}
