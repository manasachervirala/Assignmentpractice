using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonomus_method
{
    public delegate void AddSumDelegate(int a,int b);
   // public delegate string GreetinsDelegate1(string strr);
    class Program
    {

        static void Main(string[] args)
        {

            //  instantiate a delegate
            AddSumDelegate obj = delegate(int a, int b)
            {
                
                Console.WriteLine(a + b);

            };
            //GreetinsDelegate1 obj1 = delegate (string n)
            //{
            //    return "This is " + n + "Method";
            //};
            //Method is value returning method

            //obj.Invoke(100,15);
            //string strr = obj1.Invoke("mm");
            //Console.WriteLine(a +b);
            //Console.WriteLine(strr);
             obj.Invoke(100, 15);
            //string strr = obj1.Invoke("mm");
            //Console.WriteLine(a + b);
            Console.ReadLine();

        }
    }
}
