using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExercises._13_NumberLineJumps
{
    public class NumberLineJumps
    {
        public string Solve(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2 && ((x2 - x1) % (v1 - v2) == 0))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
