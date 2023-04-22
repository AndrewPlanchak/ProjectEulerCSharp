using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0007
    {
        public static void run()
        {
            int count = 0;
            int n = 0;

            while (count <= 10001)
            {
                n++;
                if (UsefulMethods.isPrime(n) == true) count++;
            }

            Console.WriteLine(n);
        } //COMPLETE
    }
}
