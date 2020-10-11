using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "manasa");
            dict[2] = "sowmya";
            dict[3] = "param";
            Console.WriteLine(" id   name");
            foreach(KeyValuePair<int,string>item in dict)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
                
            }
            Console.WriteLine("the number of elements in the dictionary is{0}", dict.Count);
            dict[6] = "son";
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + "   " + item.Value);

            }
            Console.WriteLine("the number of elements in the dictionary is{0)", dict.Count);
            Console.ReadKey();

        }
       
    }
}
