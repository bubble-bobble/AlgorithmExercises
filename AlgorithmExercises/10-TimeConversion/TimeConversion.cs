using System;

namespace AlgorithmExercises._10_TimeConversion
{
    public class TimeConversion
    {
        public string Solve(string s)
        {
            string[] timeSeparated = s.Split(':');
            string period = (timeSeparated[2][2] == 'A') ? "AM" : "PM";
            string result = string.Empty;
            if (period == "AM" && timeSeparated[0] == "12")
            {
                int hours = Convert.ToInt32(timeSeparated[0]) - 12;
                string seconds = timeSeparated[2].Replace(period, "");
                result = $"{hours}0:{timeSeparated[1]}:{seconds}";
            }
            else if (period == "PM" && timeSeparated[0] == "12")
            {
                string seconds = timeSeparated[2].Replace(period, "");
                result = $"{timeSeparated[0]}:{timeSeparated[1]}:{seconds}";
            }
            else if (period == "AM")
            {
                string seconds = timeSeparated[2].Replace(period, "");
                result = $"{timeSeparated[0]}:{timeSeparated[1]}:{seconds}";
            }
            else
            {
                int hours = Convert.ToInt32(timeSeparated[0]) + 12;
                string seconds = timeSeparated[2].Replace(period, "");
                result = $"{hours}:{timeSeparated[1]}:{seconds}";
            }
            return result;
        }
    }
}
