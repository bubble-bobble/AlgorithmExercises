using System;
using System.Collections.Generic;

namespace AlgorithmExercises._05_DiagonalDifference
{
    public class DiagonalDifference
    {
        public int Solve(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                    {
                        leftToRight += arr[i][j];
                    }
                    if (j == arr.Count - 1 - i)
                    {
                        rightToLeft += arr[i][j];
                    }
                }
            }
            int difference = Math.Abs(leftToRight - rightToLeft);
            return difference;
        }
    }
}
