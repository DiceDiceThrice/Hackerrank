using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static List<int> ServiceLane(int n, List<int> width, List<List<int>> cases)
    {
        List<int> result = new List<int>();
        
        foreach (var testCase in cases)
        {
            int i = testCase[0];
            int j = testCase[1];
            
            int minWidth = int.MaxValue;
            for (int k = i; k <= j; k++)
            {
                if (width[k] < minWidth)
                {
                    minWidth = width[k];
                }
            }
            result.Add(minWidth);
        }
        
        return result;
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int t = Convert.ToInt32(firstLine[1]);
        
        List<int> width = Console.ReadLine().TrimEnd()
                                .Split(' ')
                                .Select(widthTemp => Convert.ToInt32(widthTemp))
                                .ToList();
        
        List<List<int>> cases = new List<List<int>>();
        for (int i = 0; i < t; i++)
        {
            List<int> testCase = Console.ReadLine().TrimEnd()
                                    .Split(' ')
                                    .Select(casesTemp => Convert.ToInt32(casesTemp))
                                    .ToList();
            cases.Add(testCase);
        }
        
        List<int> result = ServiceLane(n, width, cases);
        
        foreach (int res in result)
        {
            Console.WriteLine(res);
        }
    }
}
