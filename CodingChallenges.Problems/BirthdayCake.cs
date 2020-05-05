using System;
namespace CodingChallenges.Problems
{
    public class BirthdayCake
    {
        /*You are in charge of the cake for your niece's birthday and have decided t
         * he cake will have one candle for each year of her total age.
         * When she blows out the candles, she’ll only be able to blow out the tallest ones.
         * Your task is to find out how many candles she can successfully blow out.

        For example, if your niece is turning 4 years old, and the cake will have  candles of height 4,4,1,3 ,
        she will be able to blow out 2 candles successfully, since the tallest candles are of height 4 and there are 2 such candles.

        */
        private int[] candles;
        public BirthdayCake(int [] candles)
        {
            this.candles = candles;
        }

        public void GetTallestCandles()
        {
            Array.Sort(candles);
            int tallestCandle = candles[candles.Length - 1];
            int count = 0;
            for(int i = 0; i < candles.Length; i++)
            {
                if (candles[i] == tallestCandle)
                    count++;
            }
            Console.WriteLine($"Tallest candle : {tallestCandle}, count: {count}");
        }
    }
}
