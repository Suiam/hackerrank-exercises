using System;
using System.IO;

namespace problem_sum_simple_array
{
    class Solution {

        /*
         * Complete the simpleArraySum function below.
         */
        static int simpleArraySum(int[] ar) {
            int total = 0;
            foreach(int element in ar)
            {
                total = total + element;
            }

            return total;

        }

        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
