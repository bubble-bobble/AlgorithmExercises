using System.Collections.Generic;

namespace AlgorithmExercises._04_AVeryBigSum
{
    public class AVeryBigSum
    {
        public long Solve(List<long> ar)
        {
            long result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                result += ar[i];
            }
            return result;
        }
    }
}
