using System;

namespace Q2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            string y = Console.ReadLine();

            int n;

            n = Int32.Parse(y);

            compositePrime(n);

            void compositePrime(int n)
            {
                while (n % 2 == 0)
                {
                    Console.Write(2);
                    Console.Write(" ");
                    n = n / 2;
                }

                for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
                {
                    while (n % i == 0)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                        n = n / i;
                    }
                }

                if (n > 2)
                {
                    Console.Write(n);
                    Console.Write(" ");
                }       
            }
            
        }
    }
}
