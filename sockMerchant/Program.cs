using System;
using System.Collections.Generic;

namespace sockMerchant
{
    class Solution {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var count = 0;

            Array.Sort(ar);

            for (int i = 0; i < n - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    count++;
                    i++;
                }  
            }
            return count;
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = 10;

            int[] ar = new[] {1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
                
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}