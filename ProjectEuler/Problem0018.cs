﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem0018
    {
        public static void run()
        {
            int[][] triangle = new int[][]
             {
                new int[] { 75 },
                new int[] { 95, 64 },
                new int[] { 17, 47, 82 },
                new int[] { 18, 35, 87, 10 },
                new int[] { 20, 4, 82, 47, 65 },
                new int[] { 19, 1, 23, 75, 3, 34 },
                new int[] { 88, 2, 77, 73, 7, 63, 67 },
                new int[] { 99, 65, 4, 28, 6, 16, 70, 92 },
                new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
                new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
                new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
                new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
                new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
                new int[] { 63, 66, 4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
                new int[] { 4, 62, 98, 27, 23, 9, 70, 98, 73, 93, 38, 53, 60, 4, 23 }
             };

            for (int i = triangle.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    int maxPathSum = Math.Max(triangle[i + 1][j], triangle[i + 1][j + 1]);

                    triangle[i][j] += maxPathSum;
                }
            }

            Console.WriteLine("Maximum path sum: " + triangle[0][0]);
        }
    }
}
