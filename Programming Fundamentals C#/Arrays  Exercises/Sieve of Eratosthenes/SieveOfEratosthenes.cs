using System;

namespace Sieve_of_Eratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            bool[] Primes = new bool[n];

            for (int i = 0; i < Primes.Length; i++)
            {
                Primes[i] = true;
            }

            Primes[0] = Primes[1] = false;

            for (int i = 0; i < Primes.Length; i++)
            {
                if (Primes[i] == true)
                {
                    Console.Write(i + " ");
                    for (int j = 1; j * i < Primes.Length; j++)
                    {
                        Primes[j * i] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
