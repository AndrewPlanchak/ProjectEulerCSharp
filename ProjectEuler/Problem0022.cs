using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0022
    {
        public static void run()
        {
            StreamReader sr = new StreamReader("C:\\Users\\andyp\\source\\repos\\ProjectEuler\\ProjectEuler\\Problem0022.txt");

            string dump = sr.ReadLine();

            string[] names = dump.Split(',');
            List<string> sortedNames = new List<string> { };

            foreach (string name in names)
            {
                string n = name.Substring(1, name.Length - 2);
                sortedNames.Add(n);
            }

            sortedNames.Sort();

            int pointer = 1; int total = 0;

            foreach (string n in sortedNames) { int nameTotal = 0; foreach (char c in n) { nameTotal += (int)c - 64; } total += nameTotal * pointer; pointer++; }

            Console.WriteLine(total);
        }
    }
}
