using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0012
    {
        public static void run()
        {
            int numOfDivisors = 0;
            int i = 0;
            int triNum = 0;

            while (numOfDivisors <= 500)
            {
                i++;
                triNum += i;
                int[] divisors = UsefulMethods.getDivisors(triNum);
                if (divisors != null) numOfDivisors = divisors.Length;
            }

            Console.WriteLine(triNum);
        } //COMPLETE  
    }
}
