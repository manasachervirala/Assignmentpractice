using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> x = new Dictionary<int, string>();
            x.Add(1, "bangolare");
            x.Add(2, "mumbai");
            x.Add(3, "pune");
            x.Add(4, "delhi");
            x.Add(5, "chennai");
            Console.WriteLine("the elements in dictionary are:");
            x[6] = "noida";
            x[7] = "kolkatta";
            foreach(KeyValuePair<int,string> z in x)
            {
                Console.WriteLine("the elements of dictionary are:" + z.Key + "" + z.Value);

            }
            Console.WriteLine("elements in dictionary after remove:" + x.Remove(7));
            Console.WriteLine("elements in dictionary after remove:" + x.Remove(6));
            Console.WriteLine(" THE key value pairs in dictionary are:");
            foreach (KeyValuePair<int, string> z in x)
            {
                Console.WriteLine("the elements of dictionary are:" + z.Key + "" + z.Value);

            }
            Console.WriteLine("no of elements " + x.Count);
            Console.ReadKey();
        }
    }
}
