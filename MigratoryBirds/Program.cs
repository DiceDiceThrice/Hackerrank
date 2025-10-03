using System;

class Solution
{
    static int MigratoryBirds(int[] arr)
    {
        int[] counts = new int[6]; 

        foreach (int bird in arr)
        {
            counts[bird]++;
        }

        int maxCount = 0;
        int birdId = 1;
        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                birdId = i;
            }
        }

        return birdId;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] tokens = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(tokens, int.Parse);

        int result = MigratoryBirds(arr);
        Console.WriteLine(result);
    }
}
