using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int HurdleRace(int k, List<int> height)
    {
        int maxHurdle = height.Max();
        
        return Math.Max(0, maxHurdle - k);
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int k = Convert.ToInt32(firstLine[1]);
        
        List<int> height = Console.ReadLine().TrimEnd()
                                .Split(' ')
                                .Select(heightTemp => Convert.ToInt32(heightTemp))
                                .ToList();
        
        int result = HurdleRace(k, height);
        
        Console.WriteLine(result);
    }
}
