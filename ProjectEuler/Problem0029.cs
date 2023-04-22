using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0029
    {
        public static void run()
        {
            List<double> uniqueNumber = new List<double> { };

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    double i = Math.Pow(a, b);
                    if (!uniqueNumber.Contains(i)) uniqueNumber.Add(i);
                }
            }

            Console.WriteLine(uniqueNumber.Count);
        }
    }
}
