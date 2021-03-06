﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Locks
{
    class Program
    {
        static readonly object plock = new object();
        static void PrintInfo()
        {
            lock(plock)
            {
                for(int i=1; i<4;i++)
                {
                    Console.WriteLine("i value:{0}", i);
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            Thread t2 = new Thread(new ThreadStart(PrintInfo));
            t1.Start();
            t2.Start();
            Console.ReadLine();

        }
    }
}
