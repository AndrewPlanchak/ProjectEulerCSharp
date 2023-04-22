using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0030
    {
        public static void run()
        {
            int sum = 0;

            for (int i = 2; i <= 354294; i++)
            {
                int num = i;
                int digitSum = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    digitSum += (int)Math.Pow(digit, 5);
                    num /= 10;
                }

                if (digitSum == i)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
