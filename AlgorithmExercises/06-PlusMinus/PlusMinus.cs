using System;
using System.Collections.Generic;

namespace AlgorithmExercises._06_PlusMinus
{
    public class PlusMinus
    {
        public void Solve(List<int> arr)
        {
            int positives = 0;
            int negatives = 0;
            int zeros = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    zeros++;
                }
                if (arr[i] > 0)
                {
                    positives++;
                }
                if (arr[i] < 0)
                {
                    negatives++;
                }
            }
            Console.WriteLine("{0:N6}", ((double)positives / arr.Count));
            Console.WriteLine("{0:N6}", ((double)negatives / arr.Count));
            Console.WriteLine("{0:N6}", ((double)zeros / arr.Count));
        }
    }
}
