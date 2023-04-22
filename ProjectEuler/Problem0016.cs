using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0016
    {
        public static void run()
        {
            BigInteger i = (BigInteger)Math.Pow(2, 1000);
            string number = i.ToString();
            int count = 0;
            foreach (char c in number)
            {
                count += (int)c;
            }
            Console.WriteLine(count);
        } //COMPLETE
    }
}
