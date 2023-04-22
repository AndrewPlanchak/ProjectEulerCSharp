using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0014
    {
        public static void run()
        {
            int largest = 0;

            for (int i = 0; i < 1000000; i++)
            {
                int count = 0;
                int n = i;

                while (n != 1)
                {
                    if (n % 2 == 0) n = n / 2;
                    if (n % 2 == 1) n = 3 * n + 1;
                    count++;
                }

                if (count > largest) largest = count;
            }

            Console.WriteLine(largest);
        } //COMPLETE - SLOW
    }
}
