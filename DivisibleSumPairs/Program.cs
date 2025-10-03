using System;

class Solution
{
    static int DivisibleSumPairs(int n, int k, int[] ar)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        string[] tokens = Console.ReadLine().Split(' ');
        int n = int.Parse(tokens[0]);
        int k = int.Parse(tokens[1]);

        string[] arrTokens = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(arrTokens, int.Parse);

        int result = DivisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}
