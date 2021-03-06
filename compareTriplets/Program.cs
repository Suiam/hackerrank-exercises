﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace compareTriplets
{
    class Solution {

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b) {

            List<int> total = new List<int>()  ;
            int alice = 0;
            int bob = 0 ;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] < b[i])
                {
                    bob++;
                } 
                if ( a[i] > b[i])
                {
                    alice++;
                }
            }
            
            total.Add(alice);
            total.Add(bob);
            return total;

        }

        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}