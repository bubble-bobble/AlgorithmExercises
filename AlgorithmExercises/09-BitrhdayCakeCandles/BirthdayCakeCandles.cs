using System.Collections.Generic;

namespace AlgorithmExercises._09_BitrhdayCakeCandles
{
    public class BirthdayCakeCandles
    {
        public int Solve(List<int> candles)
        {
            int tallestCandle = 0;
            int quantity = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] > tallestCandle)
                {
                    tallestCandle = candles[i];
                }
            }
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] == tallestCandle)
                {
                    quantity++;
                }
            }
            return quantity;
        }
    }
}
