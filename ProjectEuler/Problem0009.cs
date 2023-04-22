using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0009
    {
        public static void run()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (isPythagTriplet(a, b, c) == true && a + b + c == 1000) Console.WriteLine(a * b * c);
                    }
                }
            }
        } //COMPLETE
        static bool isPythagTriplet(int a, int b, int c)
        {
            if (a! < b && b! < c) return false;
            if (a * a + b * b != c * c) return false;
            return true;
        } //RETURN TRUE IF TRIPLET ELSE FALSE
    }
}
