using System;
using System.IO;

namespace diagonalDIfference
{
    class Solution {

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr, int n) {
            int diagonal1 = 0;
            int diagonal2 = 0;
            int diferença = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++ )
                {
                    if ( i == j)
                    {
                        diagonal1 += arr[i][j]; 
                    }

                    if ( i == n - j - 1)
                    {
                        diagonal2 += arr[i][j];
                    }

                }
            }

            diferença = diagonal1 - diagonal2;
            return Math.Abs(diferença);
        }

        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}