using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestnumberinarray
{
    class largestnumberinarray
    {

            static int[] arr = { 89, 3243, 4590, 90234, 93808 };

            
            static int largest()
            {
                int i;
           int max = arr[0];

              
                for (i = 1; i < arr.Length; i++)
                    if (arr[i] > max)
                        max = arr[i];

                return max;
            }

             
            public static void Main()
            {
                Console.WriteLine("Largest in given " + largest());
            Console.ReadLine();
            }
        }

    }

