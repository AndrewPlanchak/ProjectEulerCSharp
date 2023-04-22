using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0010
    {
        public static void run()
        {
            int total = 0;
            for (int i = 2; i < 2000000; i++)
            {
                if (UsefulMethods.isPrime(i) == true) total += i;
            }
            Console.WriteLine(total);
        } //NEEDS FIX - EXPECTED RESULT 142913828922
    }
}
