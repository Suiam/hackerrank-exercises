using System;
using System.IO;

namespace verybigsum
{
    class Solution {

        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar) {
            long total = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                total = total + ar[i];
            } 
        
            return total;

        }

        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
                ;
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}