using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void exam(int msg);
    class Program
    {
        public static void data(int a)
        {
            Console.WriteLine("with a parameter" + a);
        }

        static void Main(string[] args)
        {
            exam obj = data;
            obj.Invoke(12);
            Console.ReadKey();
        }
    }
}
