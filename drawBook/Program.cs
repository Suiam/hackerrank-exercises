using System;
using System.Collections.Generic;

namespace drawBook
{
    class Solution {

    
        static int pageCount(int n, int p)
        {

            var minimumpage = 0;

            if (p == 1 || p == n)
                return 0;
            
            if (n % 2 != 0 && p == n - 1)
                return 0;

            if (n % 2 == 0)
            {
                if (p <= n / 2)
                {
                    minimumpage = p / 2;
                }
                else
                {
                    var d = ((double)(n - p)) / 2;
                    minimumpage = (int)Math.Ceiling(d);
                }
            }
            else
            {
                if (p == (n/2)+1 && n % 4 == 3)
                {
                    minimumpage = (n - p) / 2;
                }
                else
                {
                    if (p <= ((n / 2) + 1))
                    {
                        minimumpage = p / 2;
                    }
                    else
                    {
                        minimumpage = (n - p) / 2;
                    }
                }
            }

            return minimumpage;
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = 6;

            int p = 5;

            int result = pageCount(n, p);
            Console.WriteLine(result);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}