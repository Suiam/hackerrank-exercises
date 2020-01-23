using System;
using System.Collections.Generic;

namespace plusminus
{
    class Solution {

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr) {
            float contagempositivos = 0;
            float contagemnegativos = 0;
            float contagemzerados = 0;

            foreach (var i in arr)
            {
                if (i > 0)
                {
                    contagempositivos++;
                } 
                else if (i < 0) 
                {
                    contagemnegativos++;
                } 
                else 
                {
                    contagemzerados++;
                }
            }

            float positive = contagempositivos / arr.Length;
            float negative = contagemnegativos / arr.Length;
            float zero = contagemzerados / arr.Length;

            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine(zero);
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            plusMinus(arr);
        }
    }
}