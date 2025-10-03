using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static List<int> Stones(int n, int a, int b)
    {
        HashSet<int> results = new HashSet<int>();
        
        for (int i = 0; i < n; i++)
        {
            int value = i * a + (n - 1 - i) * b;
            results.Add(value);
        }
        
        List<int> sortedResults = results.ToList();
        sortedResults.Sort();
        
        return sortedResults;
    }
    
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int t = 0; t < T; t++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int a = Convert.ToInt32(Console.ReadLine().Trim());
            int b = Convert.ToInt32(Console.ReadLine().Trim());
            
            List<int> result = Stones(n, a, b);
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
