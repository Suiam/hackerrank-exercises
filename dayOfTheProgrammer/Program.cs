using System;

namespace dayOfTheProgrammer
{
    class Solution
    {
        static string dayOfProgrammer(int year)
        {
            if ( year >= 1919)
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    var total = 256 - 244;
                    return (total + ".09." + year).ToString();
                }
                else
                {
                    var total = 256 - 243;
                    return (total + ".09." + year).ToString();
                }
            }

            if (year <= 1917)
            {
                if (year % 4 == 0)
                {
                    var total = 256 - 244;
                    return (total + ".09." + year).ToString();
                }
                else
                {
                    var total = 256 - 243;
                    return (total + ".09." + year).ToString();
                }
            }

            return "26.09.1918";
        }
        
        static void Main(string[] args) {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = 1800;

            string result = dayOfProgrammer(year);
            Console.WriteLine(result);

//            textWriter.WriteLine(result);
//
//            textWriter.Flush();
//            textWriter.Close();
        }
    }
}
