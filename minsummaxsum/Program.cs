using System;
using System.Linq;

namespace minsummaxsum
{
    class Solution {

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr) {
            long minimumsum = 0;
            long maximumsum = 0;
            var sortedArray = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < sortedArray.Length; i++ )
            {
                if (i != 0)
                {
                    maximumsum += sortedArray[i];
                }
                if(i != sortedArray.Length - 1)
                {
                    minimumsum += sortedArray[i];
                }
            }
            Console.WriteLine("{0} {1}", minimumsum, maximumsum);
        }

        static void Main(string[] args) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            miniMaxSum(arr);
        }
    }
}