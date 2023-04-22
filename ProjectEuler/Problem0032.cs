using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0032
    {
        public static void run()
        {
            List<int> foundNumbers = new List<int>() { }; int total = 0;
            for (int x = 0; x < 2000; x++)
            {
                for (int y = 0; y < 2000; y++)
                {
                    int z = x * y;
                    if (checkIfPandigital(x, y, z) == true && !foundNumbers.Contains(z)) { foundNumbers.Add(z); total += z; Console.WriteLine("X : {0} || Y : {1} || Z : {2}", x, y, z); }
                }
            }

            Console.WriteLine(total);
        }

        private static bool checkIfPandigital(int x, int y, int z)
        {
            string all = x.ToString() + y.ToString() + z.ToString();

            char[] chars = all.ToCharArray();
            Array.Sort(chars);

            string sorted = new string(chars);
            return sorted == "123456789";
        }
    }
}
