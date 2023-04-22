using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0027
    {
        public static void run()
        {
            //Formula n*n + a*n + b where 0 < a < 1000 && 0 < b <=1000 && n < 0

            List<int> primes = UsefulMethods.primeList(100000);


            int A = 0; int B = 0; int count = 0;

            for (int a = -999; a < 1000; a++)
            {
                for (int b = -999; b <= 1000; b++)
                {
                    int n = 0;
                    int score = 0;

                    while (primes.Contains(QuadraticFormula(a, b, n)))
                    {
                        n++;
                        score++;
                    }

                    if (score > count)
                    {
                        count = score;
                        A = a;
                        B = b;
                    }
                }
            }

            Console.WriteLine("a: " + A + ". b: " + B + ". Product: " + A * B);

            static int QuadraticFormula(int a, int b, int n)
            {
                return n * n + a * n + b;
            }
        }
    }
}
