using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0004
    {
        public static void run()
        {
            int largest = 0;
            for (int i = 111; i < 999; i++)
            {
                for (int j = 111; j < 999; j++)
                {
                    int n = i * j;
                    if (UsefulMethods.isPalendrome(n.ToString()))
                    {
                        if (n > largest) largest = n;
                    }
                }
            }
            Console.WriteLine(largest);
        } //COMPLETE
    }
}
