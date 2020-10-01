using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace series1
{
    class series
    {
        

  
// Function to calculate the sum 
 static int calculateSum(int n)
    {

            // Return total sum 
            return (int)(n * (n + 1) / 2);
        }  
  

    // Driver code 
   
    static void Main(string[] args)
        {

            int n = 2;
            Console.WriteLine(calculateSum(n));
            Console.ReadLine();

            

        }
    }
}
