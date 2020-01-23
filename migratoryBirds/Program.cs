using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;

namespace migrayoryBirds
{
    class Solution {

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr) {
            
            var q = 
                from x in arr
                group x by x into g
                let count = g.Count()
                select new { Key = g.Key, Value = count };

            var r = q.OrderByDescending(x => x.Value).ThenBy(x => x.Key).First();
            return r.Key ;
        }

        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int> {1,4,4,4,5,5,3,3,3};

            int result = migratoryBirds(arr);
            Console.WriteLine(result);
//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }
}