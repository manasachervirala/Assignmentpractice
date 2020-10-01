using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNprimenumbers
{
    class Program
    {
  

            // Function to print first N prime numbers  
            static void print_first_N_primes(int N)
            {
                // Declare the variables  
                int i, j, flag;

                // Print display message  
                Console.Write("Prime numbers between 1 and " +
                                               N + " are:\n");

                // Traverse each number from 1 to N  
                // with the help of for loop  
                for (i = 1; i <= N; i++)
                {

                    // Skip 0 and 1 as they are  
                    // niether prime nor composite  
                    if (i == 1 || i == 0)
                        continue;

                     
                    flag = 1;

                    for (j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }
                    
                    if (flag == 1)
                        Console.Write(i + " ");
                Console.ReadLine();
                }
            }

         
            public static void Main(String[] args)
            {
                int N = 100;

                print_first_N_primes(N);
            }
        }
    }

