using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0020
    {
            public static void run()
            {
                BigInteger val = 1;

                for (int i = 2; i <= 100; i++)
                {
                    val *= i;
                }

                int total = 0;

                foreach (char digit in val.ToString())
                {
                    total += int.Parse(digit.ToString());
                }

                Console.WriteLine(total);
            }
    }
}
