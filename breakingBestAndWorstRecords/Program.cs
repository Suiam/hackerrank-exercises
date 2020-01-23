using System;
using System.Collections.Generic;

namespace breakingBestAndWorstRecords
{
    class Solution {

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            var numbers = new List<int>();
            var highest = scores[0];
            var countHighest = 0;
            var countLowest = 0;
            var lowest = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                    countHighest++;
                }
                else if( scores[i] < lowest)
                {
                    lowest = scores[i];
                    countLowest++;
                }
            }
            
            numbers.Add(countHighest);
            numbers.Add(countLowest);

            return numbers.ToArray();
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = new[] {3, 4, 21};
            int[] result = breakingRecords(scores);
            //Console.WriteLine(result);

            Console.WriteLine(string.Join(" ", result));
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}