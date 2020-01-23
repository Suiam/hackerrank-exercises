using System;
using System.Collections.Generic;
using System.IO;

namespace grandingstudents
{
    class Solution {

        /*
         * Complete the gradingStudents function below.
         */
        static int[] gradingStudents(int[] grades)
        {

            List<int> numbers = new List<int>();
            int factor = 5;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38)
                {
                    numbers.Add(grades[i]);
                }
                else if (grades[i] % factor != 0)
                {

                    int nearestMultiple = grades[i] + (5 - (grades[i] % factor));

                    if (nearestMultiple - grades[i] < 3)
                    {
                        numbers.Add(nearestMultiple);
                    }
                    else if (nearestMultiple - grades[i] == 3)
                    {
                        numbers.Add(grades[i]);
                    }
                    else
                    {
                        numbers.Add(grades[i]);
                    }
                }
                else
                {
                    numbers.Add(grades[i]);
                }
            }
            
            return numbers.ToArray();
        }

        static void Main(string[] args)
        {

            
//            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//
 //           int n = Convert.ToInt32(Console.ReadLine());
//
  //          int[] grades = new int [n];
              int[] grades = new[] {23,80, 96,18,73,78,60,60,15,45,15,10,5,46,87,33,60,14,71,65};
//              int[] grades = new[] {67};  
//            
//            for (int gradesItr = 0; gradesItr < n; gradesItr++) {
//                int gradesItem = Convert.ToInt32(Console.ReadLine());
//                grades[gradesItr] = gradesItem;
//            }
//
            int[] result = gradingStudents(grades);
//
            Console.WriteLine(string.Join("\n", result));
//
//            tw.Flush();
//            tw.Close();
        }
    }
}