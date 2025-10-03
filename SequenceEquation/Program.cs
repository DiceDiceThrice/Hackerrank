using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static List<int> PermutationEquation(List<int> p)
    {
        int n = p.Count;
        List<int> result = new List<int>();
        
        Dictionary<int, int> valueToIndex = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            valueToIndex[p[i]] = i + 1;
        }
        
        // For each x from 1 to n
        for (int x = 1; x <= n; x++)
        {
            int y = valueToIndex[x];
            
            int z = valueToIndex[y];
            
            result.Add(z);
        }
        
        return result;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> p = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(pTemp => Convert.ToInt32(pTemp))
                            .ToList();
        
        List<int> result = PermutationEquation(p);
        
        foreach (int res in result)
        {
            Console.WriteLine(res);
        }
    }
}
