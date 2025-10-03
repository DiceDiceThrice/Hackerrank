using System;
using System.Collections.Generic;

class Solution
{
    static int SockMerchant(int n, int[] ar)
    {
        Dictionary<int, int> sockCounts = new Dictionary<int, int>();
        int pairs = 0;

        foreach (int sock in ar)
        {
            if (sockCounts.ContainsKey(sock))
            {
                sockCounts[sock]++;
            }
            else
            {
                sockCounts[sock] = 1;
            }
        }

        foreach (var count in sockCounts.Values)
        {
            pairs += count / 2;
        }

        return pairs;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] tokens = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(tokens, int.Parse);

        int result = SockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
