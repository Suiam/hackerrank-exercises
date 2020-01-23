using System;

namespace eletronicShops
{
    class Solution {

        /*
         * Complete the getMoneySpent function below.
         */
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var maximo = -1;    
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b && keyboards[i] + drives[j] > maximo)
                    {
                        maximo = keyboards[i] + drives[j];
                    }
                }
            }
            return maximo;
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

           // string[] bnm = Console.ReadLine().Split(' ');

           int b = 5;

            int n = 1;

            int m = 1;

            int[] keyboards = new[] {4};

            int[] drives = new[] {5};
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(moneySpent);

//            textWriter.WriteLine(moneySpent);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }
}