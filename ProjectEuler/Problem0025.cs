using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0025
    {
        public static void run()
        {
            BigInteger a = 1;
            BigInteger b = 1;
            int index = 1;
            int n = 1000;

            while (a.ToString().Length < n)
            {
                BigInteger temp = b;
                b = a + b;
                a = temp;
                index++;
            }

            Console.WriteLine(index);
        }
    }
}
