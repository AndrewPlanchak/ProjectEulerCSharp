using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0017
    {
        public static void run()
        {
            int count = 0;

            for (int i = 1; i < 1000; i++)
            {
                count += numberToWord(i);
            }

            Console.WriteLine(count + 11);
        }//COMPLETE
        static int numberToWord(int n)
        {
            string words = "";
            string[] ones = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = new[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = new[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (n == 1000)
                return "onethousand".Length;
            if (n / 100 > 0)
            {
                words += ones[n / 100] + "hundred";
                n %= 100;
                if (n > 0) words += "and";
            }
            if (n > 10 && n < 20)
                words += teens[n % 10];
            else
            {
                if (n / 10 > 0)
                {
                    words += tens[n / 10];
                    n %= 10;
                }
                if (n > 0)
                    words += ones[n];
            }
            return words.Length;
        } //RETURNS THE NUMBER OF CHARACTERS IN A NUMBER IN PLAIN ENGLISH UP TO 1000
    }
}
