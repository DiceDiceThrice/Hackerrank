using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int MinimumDistances(int[] a)
    {
        Dictionary<int, int> lastSeen = new Dictionary<int, int>();
        int minDistance = int.MaxValue;
        
        for (int i = 0; i < a.Length; i++)
        {
            if (lastSeen.ContainsKey(a[i]))
            {
                int distance = i - lastSeen[a[i]];
                minDistance = Math.Min(minDistance, distance);
            }
            
            lastSeen[a[i]] = i;
        }
        
        return minDistance == int.MaxValue ? -1 : minDistance;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        int[] a = Console.ReadLine().TrimEnd()
                        .Split(' ')
                        .Select(aTemp => Convert.ToInt32(aTemp))
                        .ToArray();
        
        int result = MinimumDistances(a);
        
        Console.WriteLine(result);
    }
}
