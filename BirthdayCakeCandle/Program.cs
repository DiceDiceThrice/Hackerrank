using System;
using System.Linq;

class Solution
{
    static int birthdayCakeCandles(int[] candles)
    {
        int maxHeight = candles.Max();
        int count = 0;
        
        foreach (int candle in candles)
        {
            if (candle == maxHeight)
            {
                count++;
            }
        }
        
        return count;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] candles = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int result = birthdayCakeCandles(candles);
        Console.WriteLine(result);
    }
}
