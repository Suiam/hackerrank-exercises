using System;

namespace appleandorange
{
    class Solution {

        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int posicaocasa1 = s;
            int posicaocasa2 = t;
            int appletree = a;
            int orangetree = b;
            int contadorapple = 0;
            int contadororange = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                
                if (appletree + apples[i] >= posicaocasa1 && appletree + apples[i] <= posicaocasa2)
                {
                    contadorapple += 1;
                }
                else
                {
                    
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
               
                if (orangetree + oranges[i] >= posicaocasa1 && orangetree + oranges[i] <= posicaocasa2 )
                {
                    contadororange += 1;
                }
                else
                {
                    
                }
                
            }
            Console.WriteLine(contadorapple);
            Console.WriteLine(contadororange);



        }

        static void Main(string[] args) {
            //string[] st = Console.ReadLine().Split(' ');

            int s = 7;

            int t = 11;

//            string[] ab = Console.ReadLine().Split(' ');

            int a = 5;

            int b = 15;

            //string[] mn = Console.ReadLine().Split(' ');

            int m = 3;

            int n = 2;

            int[] apples = new[] {-2, 2, 1};

            int[] oranges = new[] {5, -6};
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}