using System;
using System.Linq;

namespace AlgorithmExercises._07_StaircaseDetail
{
    public class StaircaseDetail
    {
        public void Solve(int n)
        {
            foreach (int value in Enumerable.Range(1, n))
            {
                Console.WriteLine(new string(' ', n - value) + new string('#', value));
            }
        }
    }
}
