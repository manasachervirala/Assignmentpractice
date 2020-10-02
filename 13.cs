using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayduplications
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {  };

            int n;
                // Traversing each element
                // in array one by one by outer for loop.
                for (int i = 0; i < n; i++)
                {

                    // Traversing starts from next
                    // element of marked element by outer loop.
                    for (int j = i + 1; j < n;)
                    {

                        // If get same element then enter here.
                        if (arr[i] == arr[j])
                        {

                            // Left shifting each element from
                            // this duplicate element upto
                            // maximum size of array element.
                            for (int k = j; k < n - 1; k++)
                            {
                                arr[k] = arr[k + 1];
                            }

                            // Decreasing the array index by 1.
                            n--;

                        }
                        else
                        {

                            // If dont get any duplicate then come here and
                            // go to next element by inner loop.
                            j++;
                        }
                    }
                }

                // Returning the final array size
                // after removing duplicate elements.
                return n;

            }
        }
    }
    }
}
