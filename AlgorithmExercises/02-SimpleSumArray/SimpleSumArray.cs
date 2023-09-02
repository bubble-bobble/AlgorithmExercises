using System.Collections.Generic;

namespace AlgorithmExercises._02_SimpleSumArray
{
    public class SimpleSumArray
    {
        public int Solve(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
