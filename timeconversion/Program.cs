using System;
using System.Globalization;
using System.IO;

namespace timeconversion
{
    class Solution {

        /*
         * Complete the timeConversion function below.
         */
        static string timeConversion(string s)
        {

            DateTime dateTime = DateTime.Parse(s);

            return dateTime.ToString("HH:mm:ss");
        }

        static void Main(string[] args) {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);
            
            Console.WriteLine(result);

//            tw.WriteLine(result);
//
//            tw.Flush();
//            tw.Close();
        }
    }
}