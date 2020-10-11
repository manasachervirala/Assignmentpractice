using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actionfuncpredicate
{
    class Program
    {
        public static void add(int x,int y)
        {
            Console.WriteLine($"{(x + y)}");
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static bool cheven(int a)
        {
            if(a%2 ==0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Action<int, int> add1 = add;
            add1(9, 7);
            Func<int, int, int> add2 = sum;
            int a = add2(3, 4);
            Console.WriteLine(a);
            Predicate<int> val = cheven;
            Console.WriteLine(val(3));
            Console.ReadKey();

        }
    }
}
