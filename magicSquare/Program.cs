using System;

namespace magicSquare
{
    class Solution {

        // Complete the formingMagicSquare function below.
        static int formingMagicSquare(int[][] s) {
            
            

        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++) {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}