using System;
using System.Collections.Generic;
using System.Linq;

namespace countingValleys
{
    class Solution {

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            var valleys = 0;
            var levels = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    levels++;
                }

                if (s[i] == 'D')
                {
                    levels--;
                }

                if (levels == 0 && s[i] == 'U')
                {
                    valleys++;
                }
            }
            return valleys;
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = 12;

            string s = "DDUUDDUDUUUD";

            int result = countingValleys(n, s);
            Console.WriteLine(result);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}