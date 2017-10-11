using System;

namespace Sieve_of_Eratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (long i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (long i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    for (long j = 1; j * i <= n; j++)
                    {
                        primes[j * i] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
