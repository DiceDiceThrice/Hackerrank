using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
    {
        int n = a.Count;
        List<int> result = new List<int>();
        
        int effectiveRotations = k % n;
        
        foreach (int query in queries)
        {
            int originalIndex = (query - effectiveRotations + n) % n;
            result.Add(a[originalIndex]);
        }
        
        return result;
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int k = Convert.ToInt32(firstLine[1]);
        int q = Convert.ToInt32(firstLine[2]);
        
        List<int> a = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(aTemp => Convert.ToInt32(aTemp))
                            .ToList();
        
        List<int> queries = new List<int>();
        for (int i = 0; i < q; i++)
        {
            queries.Add(Convert.ToInt32(Console.ReadLine().Trim()));
        }
        
        List<int> result = CircularArrayRotation(a, k, queries);
        
        foreach (int res in result)
        {
            Console.WriteLine(res);
        }
    }
}
