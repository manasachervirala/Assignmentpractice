using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_expresions
{
//    public delegate int 
    class lamdaex1
    {  
      static void Main(string[] args)
        {
            //List to store the numbers
            List<int> numbers = new List<int>()
            {
             12,24,36,48,60,72,84,96,108,120
            };
            Console.WriteLine("The elements of the List are");
            foreach(var num in numbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
          
            //using Lamda expressions to calculate squre of each number in the List()
            var square = numbers.Select
                (x => x * x);
            foreach(var value in square)
            {
                Console.WriteLine("{0}", value);
                Console.ReadLine();
            }
        }
    }
}
