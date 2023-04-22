using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0031
    {
        public static void run()
        {
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int target = 200;

            int[,] ways = new int[coins.Length, target + 1];

            // Initialize first row of table
            for (int j = 0; j <= target; j++)
            {
                ways[0, j] = 1;
            }

            // Fill in the rest of the table using recurrence relation
            for (int i = 1; i < coins.Length; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    if (j < coins[i])
                    {
                        ways[i, j] = ways[i - 1, j];
                    }
                    else
                    {
                        ways[i, j] = ways[i - 1, j] + ways[i, j - coins[i]];
                    }
                }
            }

            Console.WriteLine(ways[coins.Length - 1, target]);
        }
    }
}
