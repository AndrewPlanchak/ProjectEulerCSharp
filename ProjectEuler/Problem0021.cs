using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0021
    {
        public static void run()
        {
            int sum = 0;

            for (int i = 1; i < 10000; i++)
            {
                int divisorSum = UsefulMethods.GetDivisorSum(i);

                // Check if the sum of proper divisors of i is equal to a number other than i
                if (divisorSum != i && UsefulMethods.GetDivisorSum(divisorSum) == i)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
