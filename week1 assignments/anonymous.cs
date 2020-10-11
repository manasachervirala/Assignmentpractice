using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public delegate void Anonymous(string str, string str1);
    class Program
    {
        public static void exam1(string firstname ,string lastname)
        {
            Console.WriteLine("First name Lastname");
            Console.WriteLine(firstname + lastname);
        }
        static void Main(string[] args)
        {
            Anonymous m = new Anonymous(exam1);
            m.Invoke("manasa", "chervi");
            Console.ReadKey();
        }
    }
}
