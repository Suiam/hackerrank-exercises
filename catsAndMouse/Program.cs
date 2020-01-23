using System;

namespace catsAndMouse
{
    class Solution {

        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {

            if ( Math.Abs(x - z) < Math.Abs(y - z) )
            {
                return ("Cat A");
            }
            else if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                return ("Cat B");
            }
            else
            {
                return ("Cat C");
            }

        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

//            for (int qItr = 0; qItr < q; qItr++) {
//                string[] xyz = Console.ReadLine().Split(' ');
//
//                int x = Convert.ToInt32(xyz[0]);
//
//                int y = Convert.ToInt32(xyz[1]);
//
//                int z = Convert.ToInt32(xyz[2]);
//
//                string result = catAndMouse(x, y, z);
//
//                textWriter.WriteLine(result);
//            }
//
//            textWriter.Flush();
//            textWriter.Close();

            int x = 2;

            int y = 5;

            int z = 4;

            string result = catAndMouse(x, y, z);
            Console.WriteLine(result);
        }
    }
}