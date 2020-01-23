using System;

namespace kangaroo
{
    class Solution {

        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {

            if (x1 == x2 && v1 == v2) 
            {
                return "YES";
            }
            else if (x1 == x2 && v1 > v2)
            {
                return "NO";
            }
            else if (x1 <= x2 && v1 <= v2)
            {
                return "NO";
            }
            else 
            {
                if ((x2 - x1) % (v1 - v2) == 0)  
                {
                    return "YES";
                }
                else 
                {
                    return "NO";
                }
            }
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = 0;

            int v1 = 2;

            int x2 = 5;

            int v2 = 3;

            string result = kangaroo(x1, v1, x2, v2);
            
            Console.WriteLine(result);
//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}