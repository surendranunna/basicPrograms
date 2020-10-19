using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{

    class SumOfSquareRoots
    {
        public static void Main(String[] args)
        {
            int[] input = {};
           int res= SumOfSquareRoot(input);
            if(res>0)
            {
               
                Console.WriteLine(" the sum of perfect squares :"+res);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("no perfect square numbers are exits");
                Console.ReadLine();
            }
                
           
        }
        public static int SumOfSquareRoot(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int num = 1; num < arr[i]; num++)
                {
                    if ((arr[i] % num == 0) && ((num * num) == arr[i])) 
                    {
                        sum = sum + num;
                    }

                }
            }
               if(sum==0)
                {
                   return 0;
                }
                else if(arr.Length==0)
                {
                    return 1;
                }
               
                    return sum;
                
            }
        }
    }

