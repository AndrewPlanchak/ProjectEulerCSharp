using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0024
    {
        public static void run()
        {
            int n = 1000000; int[] digits = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int len = digits.Length;
            int[] factorial = new int[len];
            factorial[0] = 1;

            for (int i = 1; i < len; i++)
            {
                factorial[i] = factorial[i - 1] * i;
            }

            n--;

            string result = "";

            for (int i = len - 1; i >= 0; i--)
            {
                int index = n / factorial[i];
                result += digits[index].ToString();
                n -= index * factorial[i];
                digits = digits.Where((val, idx) => idx != index).ToArray();
            }

            Console.WriteLine(result);
        }
    }
}
