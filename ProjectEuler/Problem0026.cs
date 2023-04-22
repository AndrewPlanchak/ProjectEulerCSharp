using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0026
    {
        public static void run()
        {
            int maxCycleLength = 0;
            int maxD = 0;

            for (int d = 2; d < 1000; d++)
            {
                int[] remainders = new int[d];
                int value = 1;
                int position = 0;

                while (remainders[value] == 0 && value != 0)
                {
                    remainders[value] = position;
                    value = value * 10 % d;
                    position++;
                }

                if (position - remainders[value] > maxCycleLength)
                {
                    maxCycleLength = position - remainders[value];
                    maxD = d;
                }
            }

            Console.WriteLine(maxD);
        }
    }
}
