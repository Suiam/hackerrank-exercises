using System;
using System.Collections.Generic;
using System.Linq;

namespace betweenTwoSets
{
    class Solution {

        /*
         * Complete the getTotalX function below.
         */
        static int getTotalX(int[] a, int[] b)
        {
            var multiplosTotal = new Dictionary<int, int>();
            foreach (var ax in a)
            {
                for (var i = 0; ax * i <= 100; i++)
                {
                    var k = ax * i;
                    var currentValue = multiplosTotal.TryGetValue(k, out var u);
                    if (currentValue)
                    {
                        multiplosTotal[k] = u + 1;    
                    }
                    else
                    {
                        multiplosTotal.Add(k, 1);
                    }
                }
            }

            var multiplosA = multiplosTotal.Where(x => x.Value == a.Length).Select(x => x.Key);
            foreach (var v in multiplosTotal)
            {
                Console.WriteLine(v);
            }

            var factors = new HashSet<int>();
            for (var z = a[a.Length-1]; z <= b[0]; z++)
            {
                bool isFactor = true;
                foreach (var bb in b)
                {
                    isFactor = isFactor & (bb % z == 0);
                }

                if (isFactor)
                    factors.Add(z);
            }

          
            
            factors.IntersectWith(multiplosA);
            
            Console.WriteLine("FACTORS");
            foreach (var v in factors)
            {
                Console.WriteLine(v);
            }
            return factors.Count;
//            int a1 = a[0];
//            int b1 = b[0];
//            
//            List<int> multiplos = new List<int>();
//            for (int i = a1; i <= b1; i++)
//            {
//                multiplos.Add(i);
//                
//            }
//            
//            
//            List<int> multiplosA = new List<int>();
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (multiplos[i] % a[i] == 0)
//                {
//                    multiplosA.Add(i);
//                }  
//            }
//            
            
            //return 0;
        }

        static void Main(string[] args) {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] nm = Console.ReadLine().Split(' ');

            int n = 2;

            int m = 3;

            int[] a = new []{3, 4};
            int[] b = new[] {24, 48};
            
            int total = getTotalX(a, b);
            //Console.WriteLine(total);

//            tw.WriteLine(total);
//
//            tw.Flush();
//            tw.Close();
        }
    }

}