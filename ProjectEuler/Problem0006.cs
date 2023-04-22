using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0006
    {
            public static void run()
            {
                int sumOfSquares = 0;
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    sumOfSquares += (i * i);
                    sum += i;
                }

                int squareOfSums = sum * sum;

                Console.WriteLine(squareOfSums - sumOfSquares);
            } //COMPLETE
    }
}
