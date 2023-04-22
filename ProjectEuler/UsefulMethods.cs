using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class UsefulMethods
    {
        public static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 2) return true;
            if (n % 2 == 0) return false;

            var b = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i < b; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        } //Returns True if Prime else Returns Flase

        public static int[] getDivisors(int n)
        {
            List<int> divisors = new List<int>();

            if (n < 2) return null;

            else if (isPrime(n)) return null;

            else for (int i = 2; i < n; i++) if (n % i == 0) divisors.Add(i);

            return divisors.ToArray();
        } //Returns array of the divisors

        public static int GetDivisorSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }  //Returns the sum of the divisors

        public static bool[] primeArray(int n)
        {
            bool[] primes = new bool[n + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(n) + 1; i++)
            {
                if (primes[i - 1])
                {
                    for (int j = (int)Math.Pow(i, 2); j <= n; j += i)
                    {
                        primes[j - 1] = false;
                    }
                }
            }
            return primes;
        } //Returns array of bools where true = prime and false = not prime

        public static List<int> primeList(int limit)
        {
            bool[] sieve = new bool[limit + 1];
            for (int i = 2; i <= limit; i++)
            {
                sieve[i] = true;
            }

            for (int i = 2; i * i <= limit; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (sieve[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static bool isPalendrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }

            return true;
        } //Returns true if the string is palendromic
    }
}
