using System.Collections.Generic;

namespace AlgorithmExercises._03_CompareTheTriplets
{
    public class CompareTheTriplets
    {
        public List<int> Solve(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int alicePoints = 0;
            int bobPoints = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alicePoints++;
                }
                if (b[i] > a[i])
                {
                    bobPoints++;
                }
            }
            result.Add(alicePoints);
            result.Add(bobPoints);
            return result;
        }
    }
}
