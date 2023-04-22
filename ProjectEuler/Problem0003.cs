using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0003
    {
        public static void run()
        {
            long n = 600851475143; long factor = 2;

            while (n > 1)
            {
                if (n % factor == 0) { n /= factor; }
                else
                {
                    factor++;
                    if (factor * factor > n) { Console.WriteLine(n); break; }
                }
            }
        }
    }
}
