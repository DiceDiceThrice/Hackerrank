using System;

class Solution
{
    static int[] breakingRecords(int[] scores)
    {
        int maxRecord = scores[0];
        int minRecord = scores[0];
        int maxBreaks = 0;
        int minBreaks = 0;
        
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > maxRecord)
            {
                maxBreaks++;
                maxRecord = scores[i];
            }
            else if (scores[i] < minRecord)
            {
                minBreaks++;
                minRecord = scores[i];
            }
        }
        
        return new int[] { maxBreaks, minBreaks };
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        int[] result = breakingRecords(scores);
        Console.WriteLine(result[0] + " " + result[1]);
    }
}
