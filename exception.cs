using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerexception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter FN");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a sc");
                int sc = Convert.ToInt32(Console.ReadLine());
                int res = FN / sc;
                Console.WriteLine("result is {0}", res);
                Console.ReadKey();
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
