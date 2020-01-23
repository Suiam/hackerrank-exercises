using System;

namespace staircase
{
    
    class Program
    {
        static void staircase(int n) {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= (n - i))
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }

                Console.Write("\n");
            }


        }
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}

