using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actionfucand_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int, int, int> x = add;
            //x(1, 2, 9);
            //Console.ReadKey();


            var data = new List<int> { 1, -2, 3, 0, 2, -1 };

            var predicate = new Predicate<int>(IsPositive);

            var filtered = data.FindAll(predicate);
            Console.WriteLine(string.Join(",", filtered));
            //Func<int, int, int> sumfunc = sum;
            //int s = sumfunc(1, 2);
            //Console.WriteLine(s);
            Console.ReadKey();
        }
        public static void add(int x, int y,int z)
        {
            Console.WriteLine($"{(x+y+z)}");

        }
        public static int sum (int a, int b)
        {
            return a + b;
        }
        static bool IsPositive(int val)
        {
            return val > 0;
        }
    }
}
