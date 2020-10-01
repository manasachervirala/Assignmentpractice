using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatedcharcters
{
  

    public class repeatedcharacters
    {
        
        public static int count(string s, char c)
        {
            int res = 0;

            for (int i = 0; i < s.Length; i++)
            {

               
                if (s[i] == c)
                    res++;
            }

            return res;
        }

      
        public static void Main()
        {
            string str = "Hello world";
            char c = 'l';

            Console.WriteLine(count(str, c));
            Console.ReadLine();
        }
    }
 
}
