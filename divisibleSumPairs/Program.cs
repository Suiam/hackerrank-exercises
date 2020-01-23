using System;
using System.Collections.Generic;
using System.Linq;

namespace divisibleSumPairs
{
    class Solution {

        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar) {
            var divisible = 0;
            var list = new List<int>(ar);
            for (int i = 0; i <= n; i++)
            {
                for (int j = i + 1; j <= n -1; j++)
                {
                    var soma = ar[i] + ar[j];
                    
                    if (soma % k == 0)
                    {
                        divisible++;
                    }
                }  
            }

            return divisible;

        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

           // string[] nk = Console.ReadLine().Split(' ');

            int n = 6;

            int k = 5;

            int[] ar = new []{1,2,3,4,5,6}  ;
            int result = divisibleSumPairs(n, k, ar);
            
            Console.WriteLine(result);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}