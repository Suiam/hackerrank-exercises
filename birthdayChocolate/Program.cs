﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace birthdayChocolate
{
    class Solution
    {
        static int birthday(List<int> s, int d, int m)
        {

            var count = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                var soma = s.GetRange(i, m).Aggregate((a, b) => a + b);

                if (soma == d)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp))
                .ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}