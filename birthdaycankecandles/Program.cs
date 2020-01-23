using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

namespace birthdaycankecandles
{
    class Solution {

        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int totalcandles = 0;

            int max = ar.Max();

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    totalcandles++;
                }   
            }

            return totalcandles;
        }

        static void Main(string[] args) {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//
//            int arCount = Convert.ToInt32(Console.ReadLine());
//
//            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//                ;
            int result = birthdayCakeCandles(new[]{20,4,4,2,2,3,4,3,3});
            Console.WriteLine(result);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }
}