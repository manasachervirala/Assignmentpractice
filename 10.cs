using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            string month;
            Console.WriteLine("enter a year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a month");
            month = Console.ReadLine();
            if (month == "jan" ^ month == "mar" ^ month == "may" ^ month == "june" ^ month == "aug"
                ^ month == "oct" ^ month == "dec") 
            {
                Console.WriteLine("31 days");
                Console.ReadLine();
            }
            if (month == "apr" ^ month == "jun" ^ month == "sep" ^ month == "nov") 
            {
                Console.WriteLine("30days");
                Console.ReadLine();
            }
            else if(month =="feb")
            {
                if((year%4)==0^(year%100)==0^(year%400)==0)
                {
                    Console.WriteLine("29 days");
                }
                else
                {
                    Console.WriteLine("28 days");
                }
            }
            Console.ReadLine();
        }
    }
}
