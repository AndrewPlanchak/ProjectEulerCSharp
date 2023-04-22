using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0019
    {
        public static void run()
        {
            int count = 0;

            // Start with 1 Jan 1901
            DateTime date = new DateTime(1901, 1, 1);

            // Continue until 31 Dec 2000
            while (date.Year < 2001)
            {
                // If the current day is a Sunday and it's the first day of the month, increment the count
                if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1)
                {
                    count++;
                }

                // Move to the next month
                date = date.AddMonths(1);
            }

            Console.WriteLine(count);
        }
    }
}
