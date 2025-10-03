using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static string FairRations(List<int> B)
    {
        int count = 0;
        int n = B.Count;
        
        if (B.Sum() % 2 != 0)
        {
            return "NO";
        }
        
        for (int i = 0; i < n - 1; i++)
        {
            if (B[i] % 2 != 0)
            {
                B[i]++;
                B[i + 1]++;
                count += 2;
            }
        }
        
        return count.ToString();
    }
    
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> B = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(BTemp => Convert.ToInt32(BTemp))
                            .ToList();
        
        string result = FairRations(B);
        
        Console.WriteLine(result);
    }
}
