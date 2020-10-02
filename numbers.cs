using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            string name = "";
            switch(n)
            {
                case 10:
                    name = "TEN";
                    break;
                case 11:
                    name = "eleven";
                    break;
            }
            Console.WriteLine("in words is=" + name);
            Console.ReadKey();
        }
    }
}
