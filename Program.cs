using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern1
{
    class pattern1
    {
        static void Main(string[] args)
        {
      
                int i, j;
                for (i = 5; i >= 1; i--)
                {
                    for (j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

            }
        }
    }

