using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercises._12_AppleAndOrange
{
    public class AppleAndOrange
    {
        public void Solve(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int numberOfApple = 0;
            int numberOfOrange = 0;
            List<int> calculatedDistanceOfApple = new List<int>();
            List<int> calculatedDistanceOfOrange = new List<int>();
            for (int i = 0; i < apples.Count; i++)
            {
                calculatedDistanceOfApple.Add(a + apples[i]);
            }
            for (int i = 0; i < oranges.Count; i++)
            {
                calculatedDistanceOfOrange.Add(b + oranges[i]);
            }
            for(int i = 0;i < calculatedDistanceOfApple.Count; i++)
            {
                if (calculatedDistanceOfApple[i] >= s && calculatedDistanceOfApple[i] <= t)
                {
                    numberOfApple++;
                }
            }
            for (int i = 0; i < calculatedDistanceOfOrange.Count; i++)
            {
                if (calculatedDistanceOfOrange[i] >= s && calculatedDistanceOfOrange[i] <= t)
                {
                    numberOfOrange++;
                }
            }
            Console.WriteLine(numberOfApple);
            Console.WriteLine(numberOfOrange);
        }
    }
}
