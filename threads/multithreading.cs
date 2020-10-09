using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thm
{
    class Program
    {
        string Thread1()
        {
            for(int i=1; i<5;i++)
            {
                Console.WriteLine("Thread1" + i);
            }
            return ("THread1 ended");
        }
        string Thread2()
        {
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Thread2" + i);
            }
            return ("THread2 ended");
        }
        string Thread3()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Thread3" + i);
            }
            return ("THread3 ended");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Thread t1 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread1());
            });
            t1.Start();
            Thread t2 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread2());
            });
            t2.Start();
            Thread t3 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread3());
            });
            t3.Start();
            Console.ReadKey();
        }
    }
}
