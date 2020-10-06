using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regularexpresion
{
    class Program
    {
        static void Main(string[] args)
        {
        //    //Apply regex and find for match value  value =99 value = 55
        //    //Step 1: Create a RegEx = Object needs to created
        //    Regex Example = new Regex(@"\day");// find the digits present/match in the string.
        //    //step :2 call the match on the regex instance
        //    Match Match = Example.Match("Have a nice day ");
        //    //methods of regular expression
        //    //push,pop,peek,remove,count,add

            //if(Match.Success)
            //{
            //    Console.WriteLine("the value of the digit:"+ Match.Value);
            //    Console.ReadKey();
            //}
            //string Test = "aabb";
            ////match  the start of the string
            //if (Regex.IsMatch(Test, "(aa||bb)"))
                
            //{
            //    Console.WriteLine("pattern match where string is starting with ");
            //    Console.ReadKey();
            //}
            string value ="10 and 20";
            Match mch = Regex.Match(value, @"\d+");  // find th degits presents in the string!!!
            if(mch.Success)
                {
                Console.WriteLine("pattern match and the digits are:" + mch.Value);

            }
            //Step 2: Get Second Match;
            mch = mch.NextMatch();
            if(mch.Success)
            {
                Console.WriteLine("The secod executed and the digits are:" + mch.Value);
                Console.ReadLine();
            }
        }
    }
    
}
