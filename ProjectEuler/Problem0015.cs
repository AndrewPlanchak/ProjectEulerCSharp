using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0015
    {
        public static void run()
        {
            const int gridSize = 20;
            long paths = 1;

            for (int i = 0; i < gridSize; i++)
            {
                paths *= (2 * gridSize) - i;
                paths /= i + 1;
            }

            Console.WriteLine(paths);
        } //COMPLETE
    }
}
