using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gemeric_delegate
{
    public delegate void sample<T>(T param);
    class Program
    {
        public static void test(int number)
        {
            if(number %2 ==0)
            {
                Console.WriteLine("the given number {0} is even", number);

            }
            else
            {
                Console.WriteLine("the given number {0} is Odd", number);
            }
        }
        static void Main(string[] args)
        {
            sample<int> obj = new sample<int>(test);
            obj(111);
            Console.ReadKey();
        }
    }
}
