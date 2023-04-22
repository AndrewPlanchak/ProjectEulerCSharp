using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0013
    {
        public static void run()
        {
            BigInteger i = 0;

            StreamReader sr = new StreamReader(@"C:\Users\andyp\source\repos\ProjectEuler\ProjectEuler\Problem13.txt");

            while (!sr.EndOfStream)
            {
                i += BigInteger.Parse(sr.ReadLine());
            }

            Console.WriteLine(i.ToString().Substring(0, 10));
        } //COMPLETE
    }
}
