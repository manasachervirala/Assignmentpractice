using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ths
{
    class Program
    {
        string Thread1()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Thread1 at position" + i);
            }
            return ("end of the thread1");
        }
        string Thread2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread2 at position" + i);
            }
            return ("end of the thread2");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.Thread1());
            Console.WriteLine(obj.Thread2());
            Console.ReadKey();
        }
    }
}
