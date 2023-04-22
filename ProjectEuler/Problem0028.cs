using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0028
    {
        public static void run()
        {
            int size = 1001;
            int sum = 1; // Start with the center value of 1
            for (int n = 3; n <= size; n += 2)
            {
                sum += 4 * n * n - 6 * n + 6;
            }
            Console.WriteLine(sum);
        }
    }
}
