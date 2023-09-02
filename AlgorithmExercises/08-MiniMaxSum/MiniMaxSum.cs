using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExercises._08_MiniMaxSum
{
    public class MiniMaxSum
    {
        public void Solve(List<int> arr)
        {
            long minSum = long.MaxValue;
            long maxSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                long sum = arr.Sum(c => (long)c) - (long)arr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                if (sum < minSum)
                {
                    minSum = sum;
                }
            }
            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
