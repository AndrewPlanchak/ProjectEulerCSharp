using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0023
    {
        public static void run()
        {
            const int limit = 28123;

            bool[] abundant = new bool[limit + 1];
            int sum = 0;

            for (int i = 1; i <= limit; i++) abundant[i] = UsefulMethods.GetDivisorSum(i) > i;

            for (int i = 1; i <= limit; i++)
            {
                if (!IsSumOfTwoAbundant(i, abundant))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        public static bool IsSumOfTwoAbundant(int n, bool[] abundant)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                if (abundant[i] && abundant[n - i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
