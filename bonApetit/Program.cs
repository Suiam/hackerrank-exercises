using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace bonApetit
{
    class Solution {

        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int soma = 0;
            int charged = 0;
            
            for (int i = 0; i < bill.Count; i++)
            {
                if ( i == k)
                {
                    var dontEat = bill[i];
                }
                else
                {
                    soma += bill[i];
                }
            }
            Console.WriteLine(soma);

            int total = soma / 2;

            if (total == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                if (total > b)
                {
                    charged = total - b;
                }
                else
                {
                    charged = b - total;
                }
                
                Console.WriteLine(charged);
            }

        }

        static void Main(string[] args) {
           // string[] nk = new []{"3", "10","2","9"};

            //int n = Convert.ToInt32(nk[0]);

            int k = 92747;

            List<int> bill = new List<int> {};
            int b = 249191240;

            bonAppetit(bill, k, b);
        }
    }
}