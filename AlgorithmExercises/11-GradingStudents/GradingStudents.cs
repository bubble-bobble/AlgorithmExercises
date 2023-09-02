using System.Collections.Generic;

namespace AlgorithmExercises._11_GradingStudents
{
    public class GradingStudents
    {
        public List<int> Solve(List<int> grades)
        {
            List<int> finalGrades = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    finalGrades.Add(grades[i]);
                }
                else
                {
                    int nextMultipleOfFive = grades[i];
                    while (nextMultipleOfFive % 5 != 0)
                    {
                        nextMultipleOfFive++;
                    }
                    if (nextMultipleOfFive - grades[i] > 3)
                    {
                        finalGrades.Add(grades[i]);
                    }
                    else if(nextMultipleOfFive - grades[i] == 3)
                    {
                        finalGrades.Add(grades[i]);
                    }
                    else
                    {
                        finalGrades.Add(nextMultipleOfFive);
                    }
                }
            }
            return finalGrades;
        }
    }
}