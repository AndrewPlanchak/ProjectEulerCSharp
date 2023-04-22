using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0011
    {
        public static void run()
        {
            StreamReader sr = new StreamReader(@"C:\Users\andyp\source\repos\ProjectEuler\ProjectEuler\Problem0011.txt");
            List<string> lines = new List<string>();
            int lineCount = 0;

            while (!sr.EndOfStream)
            {
                lines.Add(sr.ReadLine());
                lineCount++;
            }

            int[,] matrix = new int[lineCount, lineCount];

            for (int i = 0; i < lineCount; i++)
            {
                string[] splitLine = lines[i].Split(' ');
                for (int j = 0; j < lineCount; j++)
                {
                    matrix[i, j] = int.Parse(splitLine[j]);
                }
            }

            int largest = 0;

            for (int i = 0; i < lineCount; i++)
            {
                for (int j = 0; j < lineCount; j++)
                {
                    bool upPossible = false, downPossible = false, leftPossible = false, rightPossible = false;
                    if (i - 4 > 0) upPossible = true;
                    if (j - 4 > 0) leftPossible = true;
                    if (i + 4 <= lineCount - 1) downPossible = true;
                    if (j + 4 <= lineCount - 1) rightPossible = true;

                    if (upPossible == true)
                    {
                        if (matrix[i, j] * matrix[i - 1, j] * matrix[i - 2, j] * matrix[i - 3, j] > largest) largest = matrix[i, j] * matrix[i - 1, j] * matrix[i - 2, j] * matrix[i - 3, j];
                    }
                    if (downPossible == true)
                    {
                        if (matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j] > largest) largest = matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j];
                    }
                    if (leftPossible == true)
                    {
                        if (matrix[i, j] * matrix[i, j - 1] * matrix[i, j - 2] * matrix[i, j - 3] > largest) largest = matrix[i, j] * matrix[i, j - 1] * matrix[i, j - 2] * matrix[i, j - 3];
                    }
                    if (rightPossible == true)
                    {
                        if (matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3] > largest) largest = matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3];
                    }
                    if (upPossible == true && rightPossible == true)
                    {
                        if (matrix[i, j] * matrix[i - 1, j + 1] * matrix[i - 2, j + 2] * matrix[i - 3, j + 3] > largest) largest = matrix[i, j] * matrix[i - 1, j + 1] * matrix[i - 2, j + 2] * matrix[i - 3, j + 3];
                    }
                    if (rightPossible == true && downPossible == true)
                    {
                        if (matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3] > largest) largest = matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3];
                    }
                    if (downPossible == true && leftPossible == true)
                    {
                        if (matrix[i, j] * matrix[i + 1, j - 1] * matrix[i + 2, j - 2] * matrix[i + 3, j - 3] > largest) largest = matrix[i, j] * matrix[i + 1, j - 1] * matrix[i + 2, j - 2] * matrix[i + 3, j - 3];
                    }
                    if (leftPossible == true && upPossible == true)
                    {
                        if (matrix[i, j] * matrix[i - 1, j - 1] * matrix[i - 2, j - 2] * matrix[i - 3, j - 3] > largest) largest = matrix[i, j] * matrix[i + 1, j - 1] * matrix[i + 2, j - 2] * matrix[i + 3, j - 3];
                    }
                }
            }

            Console.WriteLine(largest);


        } //COMPLETE
    }
}
