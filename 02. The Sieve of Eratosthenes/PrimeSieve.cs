using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeSieve
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int result = 2;
        List<int> primeNumbers = GeneratePrimesNaive(input);


        //for (int i = 2; i <= input; i++)
        //{
        //    result = i;
        //    if (IsPrime(result))
        //    {
        //        primeNumbers.Add(result);
        //    }
        //}
        string joined = string.Join<int>(", ", primeNumbers);
        Console.WriteLine(joined);

    }
    public static List<int> GeneratePrimesNaive(int n)
    {
        List<int> primes = new List<int>();
        primes.Add(2);
        int nextPrime = 3;
        while (nextPrime <= n)
        {
            int sqrt = (int)Math.Sqrt(nextPrime);
            bool isPrime = true;
            for (int i = 0; (int)primes[i] <= sqrt; i++)
            {
                if (nextPrime % primes[i] == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(nextPrime);
            }
            nextPrime += 2;
        }
        return primes;
    }
}