using System;
using System.Collections.Generic;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = Console.ReadLine();
            int n;
            n = Int32.Parse(y);
            int i, j;
            n = n / 2 +1;
     
            for(i = 1; i <= n; i++)
            {
                for(j=1;j <= n-i; j++)
                    Console.Write(" ");
                for(j=1;j <= 2*i-1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (i = 1; i <= n - 1; i++)
            {
                for(j=1;j<=i;j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 *(n- i) - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
