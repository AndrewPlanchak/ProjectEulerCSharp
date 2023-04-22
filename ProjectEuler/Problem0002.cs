using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0002
    {
        public static void run()
        {
            int total = 0;
            int i1 = 1, i2 = 2;

            while (i1 <= 4000000)
            {
                int temp = i2;
                i2 = i1;
                i1 = temp;

                i1 = i1 + i2;

                if (i1 % 2 == 0) total += i1;
            }

            Console.WriteLine(total);
        } //COMPLETE
    }
}
