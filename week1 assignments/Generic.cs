﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        class GenericClass<T>
        {
            public GenericClass(T msg)
            {
                Console.WriteLine(msg);
            }
        }
        class GenericClass
        {
            public void Show<T>(T msg)
            {
                Console.WriteLine(msg);
            }
        }
        static void Main(string[] args)
        {

            GenericClass<string> gen = new GenericClass<string>("This is generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');
            GenericClass genC = new GenericClass();
            genC.Show("This is generic method");
            genC.Show(101);
            genC.Show('I');
            Console.ReadKey();


        }
    }
}

